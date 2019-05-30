using System;

namespace PuncherMachine
{
    public class GClass4 : IComparable
    {
        public object object_0;
        public object object_1;
        public object object_2;

        public GClass4(object object_3, object object_4, object object_5)
        {
            object_1 = object_4;
            object_0 = object_3;
            object_2 = object_5;
        }

        int IComparable.CompareTo(object object_3)
        {
            return string.Compare(object_2 as string, ((GClass4)object_3).object_2 as string);
        }
    }
}
