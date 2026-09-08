namespace CarReportSystem {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            try {
                ApplicationConfiguration.Initialize();
                Database.Initialize();
                Application.Run(new Form1());
            }
            catch (Exception ex) {
                MessageBox.Show(
                    $"アプリケーションの起動に失敗しました。\n\n{ex.Message}",
                    "起動エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}