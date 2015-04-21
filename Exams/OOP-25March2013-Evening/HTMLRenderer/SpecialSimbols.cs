namespace HTMLRenderer
{
    using System.Collections.Generic;
    public static class SpecialSimbols
    {
        public static Dictionary<char, string> SpecialSimbolsDic = new Dictionary<char,string> { { '<', "&lt" }, { '>', "&gt" }, { '&', "&amp" } };
    }
}
