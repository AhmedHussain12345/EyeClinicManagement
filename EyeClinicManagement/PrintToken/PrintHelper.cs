using System;
using System.Drawing;
using System.Drawing.Printing;

namespace EyeClinicManagement.PrintToken
{
    public class PrintHelper
    {
        public static int headerFont = 14;
        public static int contentFont = 9;
        public static string FontStyleHeader = "Broadway";
        public static string FontStyleContent = "Verdana";
        public static string Title = "          Eye Clinic Management".ToUpper();

        public static void CreateReceipt(object sender, PrintPageEventArgs e, tblOpd opd)
        {
            Graphics graphic = e.Graphics;
            Font headerFont = new Font(FontStyleHeader, 14, FontStyle.Bold);
            Font contentFont = new Font(FontStyleContent, 9, FontStyle.Regular);

            double fontHeight = contentFont.GetHeight();
            int startX = 10;
            int startY = 10;
            int offset = 40;

            // Print the title
            graphic.DrawString(Title, headerFont, new SolidBrush(Color.Black), startX, startY);
            offset += (int)fontHeight + 10;

            // Print the OPD details
            graphic.DrawString("Receipt", contentFont, new SolidBrush(Color.Black), startX, startY + offset);
            offset += (int)fontHeight + 5;

            graphic.DrawString("----------------------------------", contentFont, new SolidBrush(Color.Black), startX, startY + offset);
            offset += (int)fontHeight;

            // Displaying OPD details
            graphic.DrawString($"Name: {opd.Name}", contentFont, new SolidBrush(Color.Black), startX, startY + offset);
            offset += (int)fontHeight;
            graphic.DrawString($"Slip No: {opd.Slipno}", contentFont, new SolidBrush(Color.Black), startX, startY + offset);
            offset += (int)fontHeight;
            graphic.DrawString($"Age: {opd.Age}", contentFont, new SolidBrush(Color.Black), startX, startY + offset);
            offset += (int)fontHeight;
            graphic.DrawString($"Gender: {opd.Gender}", contentFont, new SolidBrush(Color.Black), startX, startY + offset);
            offset += (int)fontHeight;
            graphic.DrawString($"Contact: {opd.Contact}", contentFont, new SolidBrush(Color.Black), startX, startY + offset);
            offset += (int)fontHeight;
            graphic.DrawString($"Address: {opd.Address}", contentFont, new SolidBrush(Color.Black), startX, startY + offset);
            offset += (int)fontHeight;
            graphic.DrawString($"Total Amount: Rs. {opd.Amount}", contentFont, new SolidBrush(Color.Black), startX, startY + offset);
            offset += (int)fontHeight + 20;

            // Thank you message
            graphic.DrawString("Thank you for visiting!", contentFont, new SolidBrush(Color.Black), startX, startY + offset);
        }
    }
    }
