using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Liber
{
    public static class constants
    {
        public static String[] formats = { "PDF", "DOC", "DOCX", "ODT", "TXT" };
        public static String[] langsString = { "English", "Spanish" };
        public static PSLibrary.G11N.g11n.Languages[] langs = {
                                                                  PSLibrary.G11N.g11n.Languages.EN,
                                                                  PSLibrary.G11N.g11n.Languages.ES
                                                              };
    }
}
