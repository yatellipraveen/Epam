using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LifeCycle
{
    public partial class _Default : Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
          //  Label1.Text = Label1.Text + "PreInit";
        
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            Label1.Text = Label1.Text + "Init ";
        }

        protected void Page_LoadViewState(object sender, EventArgs e)
        {
            Label1.Text = Label1.Text + "LoadViewState ";
        }

        protected void Page_LoadPostData(object sender, EventArgs e)
        {
            Label1.Text = Label1.Text + "LoadPostData ";
        }

        protected void Page_PreLoad(object sender, EventArgs e)
        {
            Label1.Text = Label1.Text + "PreLoad ";
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Label1.Text + "Load ";
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            Label1.Text = Label1.Text + "LoadComplete ";
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            Label1.Text = Label1.Text + "PreRender ";
        }

        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {
            Label1.Text = Label1.Text + "PreRenderComplete ";
        }
        protected void Page_SaveStateComplete(object sender, EventArgs e)
        {
            Label1.Text = Label1.Text + "SaveStateComplete ";
        }
        protected void Page_UnLoad(object sender, EventArgs e)
        {
            Label1.Text = Label1.Text + "UnLoad ";
        }
    }
}