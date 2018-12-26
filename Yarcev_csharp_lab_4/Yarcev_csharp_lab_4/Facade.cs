using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yarcev_csharp_lab_4
{
    /// <summary>
    /// управляющий класс
    /// </summary>
    class Facade
    {
        private Subsystem_1 sub1 = new Subsystem_1();
        private Subsystem_2 sub2 = new Subsystem_2();
        private Subsystem_3 sub3 = new Subsystem_3();
        private Subsystem_4 sub4 = new Subsystem_4();
        private Subsystem_5 sub5 = new Subsystem_5();
        private Subsystem_6 sub6 = new Subsystem_6();
        private Subsystem_7 sub7 = new Subsystem_7();
        public void Subsystem_1() { this.sub1.Procedutre(); }
        public void Subsystem_2() { this.sub2.Procedutre(); }
        public void Subsystem_3() { this.sub3.Procedutre(); }
        public void Subsystem_4() { this.sub4.Procedutre(); }
        public void Subsystem_5() { this.sub5.Procedutre(); }
        public void Subsystem_6() { this.sub6.Procedutre(); }
        public void Subsystem_7() { this.sub7.Procedutre(); }
    }
}
