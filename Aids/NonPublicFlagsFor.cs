using System.Reflection;

namespace ReservationProject.Aids {
    public static class NonPublicFlagsFor {
        private const BindingFlags Pub = BindingFlags.NonPublic;
        private const BindingFlags Inst = BindingFlags.Instance;
        private const BindingFlags Stat = BindingFlags.Static;
        private const BindingFlags Decl = BindingFlags.DeclaredOnly;
        public const BindingFlags All = Pub | Inst | Stat;
        public const BindingFlags Instance = Pub | Inst;
        public const BindingFlags Static = Pub | Stat;
        public const BindingFlags Declared = Pub | Decl | Inst | Stat; 
    }
}
