using System.Diagnostics;


namespace GTA_Online_Session_Emptier.src.utils
{
    internal class EmptySession
    {
        private static async Task WaitForSessionEmpty()
        {
            await Task.Delay(8000);
        }

        public static async Task<bool> Empty(int procPid)
        {
            try
            {
                var gameProcess = Process.GetProcessById(procPid);
                gameProcess.Suspend();
                await WaitForSessionEmpty();
                gameProcess.Resume();
                return true;
            } catch
            {
                return false;
            }
        }
    }
}
