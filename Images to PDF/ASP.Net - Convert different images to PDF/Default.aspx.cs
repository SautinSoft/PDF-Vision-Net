using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Drawing;
using System.Collections.Generic;

public partial class _Default : System.Web.UI.Page 
{
  
    protected void Page_Load(object sender, EventArgs e)
    {
        Result.Text = "";   
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SautinSoft.PdfVision v  = new SautinSoft.PdfVision();

        List<byte[]> imgInventory = new List<byte[]>();

        if (FileUpload1.FileBytes.Length > 0)
            imgInventory.Add(FileUpload1.FileBytes);

        if (FileUpload2.FileBytes.Length > 0)
            imgInventory.Add(FileUpload2.FileBytes);

        if (FileUpload3.FileBytes.Length > 0)
            imgInventory.Add(FileUpload3.FileBytes);

        if (FileUpload4.FileBytes.Length > 0)
            imgInventory.Add(FileUpload4.FileBytes);

        //convert arraylist with image streams to pdf stream
        byte[] pdfBytes = v.ConvertImageStreamArrayToPDFStream(imgInventory);
        
        // show PDF
        if (pdfBytes != null)
        {
            Response.Buffer = true;
            Response.Clear();
            Response.ContentType = "application/PDF";
			
            // Response.AddHeader("content-disposition", "attachment; filename=Result.pdf");
            Response.AddHeader("content-disposition", "inline; filename=Result.pdf");
            Response.BinaryWrite(pdfBytes);
            Response.Flush();
            Response.End();
        }
        else
        {
            Result.Text = "Converting failed!";
        }
    }    
}
