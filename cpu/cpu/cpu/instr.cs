using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpu
{
    internal class instr : IEquatable<instr>, IComparable<instr>, IEnumerable<instr>
    {
        public string Name { get; set; }
        public int ID { get; set; }
        private IList<instr> _ins;
        public override string ToString()
        {
            return "ID: " + ID + "   Name: " + Name;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            instr objAsInstr = obj as instr;
            if (objAsInstr == null) return false;
            else return Equals(objAsInstr);
        }
        public override int GetHashCode()
        {
            return ID;
        }
        public bool Equals(instr other)
        {
            if (other == null) return false;
            return (this.ID.Equals(other.ID));
        }
        public int CompareTo(instr compareInstr)
        {
            if (compareInstr == null)
                return 1;

            else
                return this.ID.CompareTo(compareInstr.ID);
        }
        public static bool EndsWithVariable(String s)
        {
            return s.ToLower().EndsWith("Variable");
        }
        public IEnumerator<instr> GetEnumerator()
        {
            foreach (instr iN in _ins)
            {
                yield return iN;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

