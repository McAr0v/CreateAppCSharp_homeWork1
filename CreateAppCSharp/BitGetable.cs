using System;
using System.Runtime.CompilerServices;

namespace CreateAppSCharp {

    public interface IBitGetable
    {
        bool GetBitByIndex(byte index);

        void SetBitByIndex(byte index, bool value);

    }

    public class Bits : IBitGetable
    {
        public long Value { get; private set; }

        public int Size { get; private set; }

        public Bits(byte value)
        {
            Value = value;
            Size = sizeof(byte);
        }

        public Bits(int value)
        {
            Value = value;
            Size = sizeof(int);
        }

        public Bits(long value)
        {
            Value = value;
            Size = sizeof(long);
        }

        public bool GetBitByIndex(byte index)
        {
            return (Value & (1 << index)) != 0;
        }

        public void SetBitByIndex(byte index, bool value)
        {
            if (value)
            {
                Value |= (1L << index);
            }
            else { Value &= ~(1L << index); }
        }

        public bool this[byte index]
        {
            get => GetBitByIndex(index);
            set => SetBitByIndex(index, value);
        }

        public static implicit operator long(Bits bits) => (long)bits.Value;

        public static explicit operator Bits(long value) => new(value);

        // ---- ДОБАВЛЕННЫЙ КОД ДЛЯ ДОМАШКИ НИЖЕ))) ----

        public static implicit operator byte(Bits bits) => (byte)bits.Value;

        public static explicit operator Bits(byte value) => new(value);

        public static implicit operator int(Bits bits) => (int)bits.Value;

        public static explicit operator Bits(int value) => new(value);

    }

    

}

