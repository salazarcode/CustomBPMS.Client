namespace CustomBPMS.Client.Pages
{
    public partial class Landing
    {
        bool bordersOn = true;

        public string AddBorderIfOn(string originalClasses)
        {
            string? border = bordersOn ? "magenta_border" : null;
            var res = $"{originalClasses} {border}";
            return res;
        }

        public void ToogleBorders()
        {
            bordersOn = !bordersOn;
        }

    }
}