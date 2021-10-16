// Author: James Johnson
// Purpose: Template created to demonstrate math operations


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace CashRegisterSummative
{
    public partial class Form1 : Form
    {
        // Declaring Variables
        double clockPrice = 40.45;
        double penPrice = 16.43;
        double postItNotePrice = 8.45;

        double clockTotalPrice;
        double penTotalPrice;
        double postItNoteTotalPrice;

        int clockQuantity;
        int penQuantity;
        int postItNoteQuantity;

        double basicTotalCost;

        double taxRate = 0.13;
        double taxAmount;

        double tendered;
        double change;

        double totalCost;
        SoundPlayer printSound;

        public Form1()
        {
            // This is called when the program starts
            InitializeComponent();
            this.Size = new Size(410, 497);
            printSound = new SoundPlayer(Properties.Resources.printSound);
            WaitingForOrder();
        }

        private void calcTotalButton_Click(object sender, EventArgs e)
        {
            CalculateTotal(); // Calculate the Total when this button is pressed
        }


        private void CalculateTotal()
        {
            try //Try to get the input of the Text Input areas
            {
                clockQuantity = Convert.ToInt32(numOfClocksInput.Text);
                penQuantity = Convert.ToInt32(numOfPensInput.Text);
                postItNoteQuantity = Convert.ToInt32(numOfNotesInput.Text);

                clockTotalPrice = clockQuantity * clockPrice; // Calculate the total prices of each section of the order
                penTotalPrice = penQuantity * penPrice;
                postItNoteTotalPrice = postItNoteQuantity * postItNotePrice;

                basicTotalCost = clockTotalPrice + penTotalPrice + postItNoteTotalPrice;

                totalCost = basicTotalCost * (1 + taxRate);
                taxAmount = totalCost - basicTotalCost;

                subTotalText.Text = $"{basicTotalCost.ToString("C")}"; // Show the totalText and such
                taxText.Text = $"{taxAmount.ToString("C")}";
                totalText.Text = $"{totalCost.ToString("C")}";

                changeButton.Enabled = true;

                numOfClocksInput.Enabled = false; // Makes it so when you press calculate, you can't edit the numbers until
                numOfPensInput.Enabled = false;   // you make a new order
                numOfNotesInput.Enabled = false;
                calcTotalButton.Enabled = false;
                tenderedInput.Enabled = true;

                if (totalCost == 0) // Try ordering nothing
                {
                    orderLabel.Text = "...You're ordering nothing?";
                }

            }
            catch //If an error happens (No input or non numbers), Default to 0
            {
                if (numOfClocksInput.Text == "") // If nothing is detected or doesn't format correctly. Default to 0
                {
                    clockQuantity = 0;
                }
                else
                {
                    try
                    {
                        clockQuantity = Convert.ToInt32(numOfClocksInput.Text); // This is called if we get an error
                        // and we still need to update 
                    }
                    catch
                    {
                        orderLabel.Text = "Please Input a Whole Number";
                    }
                }

                if (numOfPensInput.Text == "")
                {
                    penQuantity = 0;
                }
                else
                {
                    try
                    {
                        penQuantity = Convert.ToInt32(numOfPensInput.Text);
                    }
                    catch
                    {
                        orderLabel.Text = "Please Input a Whole Number";
                    }
                }

                if (numOfNotesInput.Text == "")
                {
                    postItNoteQuantity = 0;
                }
                else
                {
                    try
                    {
                        postItNoteQuantity = Convert.ToInt32(numOfNotesInput.Text);
                    }
                    catch
                    {
                        orderLabel.Text = "Please Input a Whole Number";
                    }
                }


            }



        }

        private async void PrintReceipt()
        {
            receiptLabel.Visible = true; // The labels are hidden just incase the application gets made bigger on the screen (its turned off but just incase)
            recieptProgressBar.Visible = true;
            newOrderButton.Visible = true;

            waitingLabel.ForeColor = Color.Gainsboro; // Sets the "Waiting for Order" text to White to not show it.
            printReceiptButton.Enabled = false;
            this.Size = new Size(600, 497); // Shows the Receipt Printing Area

            printSound.Stream.Position = 0; // Makes sure its at the front of the 'sound queue'
            printSound.Play(); // Start playing receipt sound
            recieptProgressBar.Value = 5;
            receiptLabel.Text = $"Welcome to The Store(TM)!\n";

            await Task.Delay(1000);

            if (clockQuantity > 0) // Checks to see if any clocks were ordered.
            {
                receiptLabel.Text += $"\nClocks        x{clockQuantity} @ {clockTotalPrice.ToString("C")}"; // Adds the text to the receipt
                await Task.Delay(500); //Waits
            }
            recieptProgressBar.Value = 10; // Adds progress to the progress bar
            if (penQuantity > 0)
            {
                receiptLabel.Text += $"\nPens        x{penQuantity} @ {penTotalPrice.ToString("C")}";
                await Task.Delay(500);
            }
            recieptProgressBar.Value += 10;
            if (postItNoteQuantity > 0)
            {
                receiptLabel.Text += $"\nNotes      x{postItNoteQuantity} @ {postItNoteTotalPrice.ToString("C")}";
                await Task.Delay(500);
            }
            recieptProgressBar.Value += 10;
            receiptLabel.Text += $"\n\nSubtotal      {basicTotalCost.ToString("C")}";
            recieptProgressBar.Value += 10;
            await Task.Delay(500);

            receiptLabel.Text += $"\nTax         {taxAmount.ToString("C")}";
            recieptProgressBar.Value += 10;
            await Task.Delay(500);

            receiptLabel.Text += $"\nTotal       {totalCost.ToString("C")}";
            recieptProgressBar.Value += 10;
            await Task.Delay(500);

            receiptLabel.Text += $"\n\nTendered      {tendered.ToString("C")}";
            recieptProgressBar.Value += 10;
            await Task.Delay(500);

            receiptLabel.Text += $"\nChange      {change.ToString("C")}";
            recieptProgressBar.Value += 10;
            await Task.Delay(500);

            receiptLabel.Text += $"\n\nThank you for Shopping at The Store(TM)!";
            recieptProgressBar.Value += 10;
            await Task.Delay(500);

            receiptLabel.Text += $"\n\nHave a nice day!!";
            recieptProgressBar.Value += 10;
            await Task.Delay(500);

            newOrderButton.Enabled = true; // Allows you to start a new order
            printSound.Stop();
        }

        private async void WaitingForOrder() //Show a breif animation when waiting for an Order
        {
            waitingLabel.Text = "Waiting For Order.";
            await Task.Delay(500); // This is able to delay without freezing the application & not allowing Input
            Refresh();
            waitingLabel.Text = "Waiting For Order..";
            await Task.Delay(500);
            Refresh();
            waitingLabel.Text = "Waiting For Order...";
            await Task.Delay(500);
            Refresh();
            WaitingForOrder();
        }

        private void printReceiptButton_Click(object sender, EventArgs e)
        {
            PrintReceipt();
        }


        private void changeButton_Click(object sender, EventArgs e)
        {
            CalculateChange();
        }

        private void CalculateChange()
        {

            try
            {
                tendered = Convert.ToInt32(tenderedInput.Text);
                change = tendered - totalCost;
            }
            catch
            {
                changeText.Text = "Please Insert a Whole Number";
            }

            if (tendered >= totalCost)
            {
                changeText.Text = $"{change.ToString("C")}";

                printReceiptButton.Enabled = true; //If everything works, you are allowed to print the receipt
                tenderedInput.Enabled = false; // Disable the input that we just finished to prevent any issues
                changeButton.Enabled = false;
            }
            else
            {
                changeText.Text = $"Please Give more than {totalCost.ToString("C")}";
            }

        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            clockQuantity = 0; // Resets almost every variable that does get changed during the useage of the program
            penQuantity = 0;
            postItNoteQuantity = 0;

            clockTotalPrice = 0;
            penTotalPrice = 0;
            postItNoteTotalPrice = 0;

            basicTotalCost = 0;
            taxAmount = 0;
            totalCost = 0;
            tendered = 0;
            change = 0;

            numOfClocksInput.Text = ""; // Resets the Input text sections
            numOfPensInput.Text = "";
            numOfNotesInput.Text = "";

            subTotalText.Text = $"$0.00"; // Show the totalText and such
            taxText.Text = $"$0.00";
            totalText.Text = $"$0.00";
            changeText.Text = "$0.00";

            receiptLabel.Text = "";
            tenderedInput.Text = "";


            waitingLabel.ForeColor = Color.Black; // Enables / Disables Buttons
            printReceiptButton.Enabled = false;
            changeButton.Enabled = false;
            newOrderButton.Enabled = false;
            changeButton.Enabled = false;

            numOfClocksInput.Enabled = true; // ALot of code to reset everything
            numOfPensInput.Enabled = true;
            numOfNotesInput.Enabled = true;
            tenderedInput.Enabled = false;
            calcTotalButton.Enabled = true;
            orderLabel.Text = "Order Here!";

            receiptLabel.Visible = false;
            recieptProgressBar.Visible = false;
            newOrderButton.Visible = false;

            recieptProgressBar.Value = 0; // Resets progress Bar
            this.Size = new Size(410, 497); // Resets size to *not* show the receipt
        }
    }
}
