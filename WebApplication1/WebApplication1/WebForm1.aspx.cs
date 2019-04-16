using System;
using System.Web.UI.WebControls;
using System.Xml;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public ServiceReference1.Service1Client serv = new ServiceReference1.Service1Client();

        protected void Page_Load(object sender, EventArgs e){
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox2.Text = "";
            XmlDocument doc = new XmlDocument();
            doc.Load(TextBox1.Text);
            XmlNode root = doc.DocumentElement;
            OutputNode(root, "");
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox2.Text = serv.verify(TextBox1.Text, TextBox3.Text);
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox2.Text = serv.xpathsearch(TextBox1.Text, TextBox4.Text);
        }
        protected void BulletedList1_Click(object sender, BulletedListEventArgs e){}
        protected void TextBox1_TextChanged(object sender, EventArgs e){}
        public void OutputNode(XmlNode node, String space)
        {
            if (node == null) Environment.Exit(1);
            if(node.Value != null){TextBox2.Text += space + "└──┤" + node.Value + "\r\n";
            }else{
                string att = "";
                foreach(XmlAttribute x in node.Attributes)
                {
                    att += " {" + x.Name + ": "+ x.Value + "}";
                }
                TextBox2.Text += space + "└┬─>" + node.Name + att +"\r\n";
            }           
            if (node.HasChildNodes)
            {
                XmlNodeList children = node.ChildNodes;
                foreach (XmlNode child in children)
                        OutputNode(child, " " + space);   // recursive
            }
        }
        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {}

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}