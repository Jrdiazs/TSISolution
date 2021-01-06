using System;
using System.Windows.Forms;

namespace TSI.AppWindows.Modal.Info
{
    public static class ModalInfo
    {
        public static void ShowInfo(this IWin32Window window, string mensaje, string titulo = "Info")
        {
            MessageBox.Show(window, mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowError(this IWin32Window window, Exception ex, string titulo = "Error")
        {
            MessageBox.Show(window, string.Format("Error : {0}", ex.Message), titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}