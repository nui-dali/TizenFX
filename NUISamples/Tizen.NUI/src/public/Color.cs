// Copyright (c) 2017 Samsung Electronics Co., Ltd.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
//
// This File has been auto-generated by SWIG and then modified using DALi Ruby Scripts
// Some have been manually changed

namespace Tizen.NUI
{

    using System;

    /// <summary>
    /// Color class
    /// </summary>
    public class Color : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal Color(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Color obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~Color()
        {
            DisposeQueue.Instance.Add(this);
        }

        /// <summary>
        /// To make Color instance be disposed.
        /// </summary>
        public virtual void Dispose()
        {
            if (!Stage.IsInstalled())
            {
                DisposeQueue.Instance.Add(this);
                return;
            }

            lock (this)
            {
                if (swigCPtr.Handle != global::System.IntPtr.Zero)
                {
                    if (swigCMemOwn)
                    {
                        swigCMemOwn = false;
                        NDalicPINVOKE.delete_Vector4(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }

        /// <summary>
        /// Addition operator.
        /// </summary>
        /// <param name="arg1">First value</param>
        /// <param name="arg2">Second value</param>
        /// <returns>A Color containing the result of the addition</returns>
        public static Color operator +(Color arg1, Color arg2)
        {
            return arg1.Add(arg2);
        }

        /// <summary>
        /// Subtraction operator.
        /// </summary>
        /// <param name="arg1">First value</param>
        /// <param name="arg2">Second value</param>
        /// <returns>A Color containing the result of the subtraction</returns>
        public static Color operator -(Color arg1, Color arg2)
        {
            return arg1.Subtract(arg2);
        }

        /// <summary>
        /// Unary negation operator.
        /// </summary>
        /// <param name="arg1">Target Value</param>
        /// <returns>A Color containg the negation</returns>
        public static Color operator -(Color arg1)
        {
            return arg1.Subtract();
        }

        /// <summary>
        /// Multiplication operator.
        /// </summary>
        /// <param name="arg1">First Value</param>
        /// <param name="arg2">Second Value</param>
        /// <returns>A Color containing the result of the multiplication</returns>
        public static Color operator *(Color arg1, Color arg2)
        {
            return arg1.Multiply(arg2);
        }

        /// <summary>
        /// Division operator.
        /// </summary>
        /// <param name="arg1">First Value</param>
        /// <param name="arg2">Second Value</param>
        /// <returns>A Color containing the result of the division</returns>
        public static Color operator /(Color arg1, Color arg2)
        {
            return arg1.Divide(arg2);
        }

        /// <summary>
        /// Array subscript operator overload.
        /// </summary>
        /// <param name="index">Subscript index</param>
        /// <returns>The float at the given index</returns>
        public float this[uint index]
        {
            get
            {
                return ValueOfIndex(index);
            }
        }

        internal static Color GetColorFromPtr(global::System.IntPtr cPtr)
        {
            Color ret = new Color(cPtr, false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Color() : this(NDalicPINVOKE.new_Vector4__SWIG_0(), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }


        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="r">red component</param>
        /// <param name="g">green component</param>
        /// <param name="b">blue component</param>
        /// <param name="a">alpha component</param>
        public Color(float r, float g, float b, float a) : this(NDalicPINVOKE.new_Vector4__SWIG_1(r, g, b, a), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Conversion constructor from an array of four floats.
        /// </summary>
        /// <param name="array">array Array of R,G,B,A</param>
        public Color(float[] array) : this(NDalicPINVOKE.new_Vector4__SWIG_2(array), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        private Color Add(Color rhs)
        {
            Color ret = new Color(NDalicPINVOKE.Vector4_Add(swigCPtr, Color.getCPtr(rhs)), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Color AddAssign(Vector4 rhs)
        {
            Color ret = new Color(NDalicPINVOKE.Vector4_AddAssign(swigCPtr, Color.getCPtr(rhs)), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Color Subtract(Color rhs)
        {
            Color ret = new Color(NDalicPINVOKE.Vector4_Subtract__SWIG_0(swigCPtr, Color.getCPtr(rhs)), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Color SubtractAssign(Color rhs)
        {
            Color ret = new Color(NDalicPINVOKE.Vector4_SubtractAssign(swigCPtr, Color.getCPtr(rhs)), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Color Multiply(Color rhs)
        {
            Color ret = new Color(NDalicPINVOKE.Vector4_Multiply__SWIG_0(swigCPtr, Color.getCPtr(rhs)), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Color MultiplyAssign(Color rhs)
        {
            Color ret = new Color(NDalicPINVOKE.Vector4_MultiplyAssign__SWIG_0(swigCPtr, Color.getCPtr(rhs)), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Color MultiplyAssign(float rhs)
        {
            Color ret = new Color(NDalicPINVOKE.Vector4_MultiplyAssign__SWIG_1(swigCPtr, rhs), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Color Divide(Vector4 rhs)
        {
            Color ret = new Color(NDalicPINVOKE.Vector4_Divide__SWIG_0(swigCPtr, Color.getCPtr(rhs)), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }


        private Color DivideAssign(Color rhs)
        {
            Color ret = new Color(NDalicPINVOKE.Vector4_DivideAssign__SWIG_0(swigCPtr, Color.getCPtr(rhs)), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Color DivideAssign(float rhs)
        {
            Color ret = new Color(NDalicPINVOKE.Vector4_DivideAssign__SWIG_1(swigCPtr, rhs), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Color Subtract()
        {
            Color ret = new Color(NDalicPINVOKE.Vector4_Subtract__SWIG_1(swigCPtr), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Check if two Color classes are same.
        /// </summary>
        /// <param name="rhs">A Color to be compared</param>
        /// <returns>If two Colors are are same, then true.</returns>
        public bool EqualTo(Color rhs)
        {
            bool ret = NDalicPINVOKE.Vector4_EqualTo(swigCPtr, Color.getCPtr(rhs));

            if (rhs == null) return false;

            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Check if two Color classes are different.
        /// </summary>
        /// <param name="rhs">A Color to be compared</param>
        /// <returns>If two Colors are are different, then true.</returns>
        public bool NotEqualTo(Color rhs)
        {
            bool ret = NDalicPINVOKE.Vector4_NotEqualTo(swigCPtr, Color.getCPtr(rhs));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }


        private float ValueOfIndex(uint index)
        {
            float ret = NDalicPINVOKE.Vector4_ValueOfIndex__SWIG_0(swigCPtr, index);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// red component
        /// </summary>
        public float R
        {
            set
            {
                NDalicPINVOKE.Vector4_r_set(swigCPtr, value);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                float ret = NDalicPINVOKE.Vector4_r_get(swigCPtr);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// green component
        /// </summary>
        public float G
        {
            set
            {
                NDalicPINVOKE.Vector4_g_set(swigCPtr, value);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                float ret = NDalicPINVOKE.Vector4_g_get(swigCPtr);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// blue component
        /// </summary>
        public float B
        {
            set
            {
                NDalicPINVOKE.Vector4_b_set(swigCPtr, value);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                float ret = NDalicPINVOKE.Vector4_b_get(swigCPtr);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// alpha component
        /// </summary>
        public float A
        {
            set
            {
                NDalicPINVOKE.Vector4_a_set(swigCPtr, value);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                float ret = NDalicPINVOKE.Vector4_a_get(swigCPtr);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// Get black colored Color class
        /// </summary>
        public static Color Black
        {
            get
            {
                global::System.IntPtr cPtr = NDalicPINVOKE.BLACK_get();
                Color ret = (cPtr == global::System.IntPtr.Zero) ? null : new Color(cPtr, false);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// Get white colored Color class
        /// </summary>
        public static Color White
        {
            get
            {
                global::System.IntPtr cPtr = NDalicPINVOKE.WHITE_get();
                Color ret = (cPtr == global::System.IntPtr.Zero) ? null : new Color(cPtr, false);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// Get red colored Color class
        /// </summary>
        public static Color Red
        {
            get
            {
                global::System.IntPtr cPtr = NDalicPINVOKE.RED_get();
                Color ret = (cPtr == global::System.IntPtr.Zero) ? null : new Color(cPtr, false);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// Get green colored Color class
        /// </summary>
        public static Color Green
        {
            get
            {
                global::System.IntPtr cPtr = NDalicPINVOKE.GREEN_get();
                Color ret = (cPtr == global::System.IntPtr.Zero) ? null : new Color(cPtr, false);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// Get blue colored Color class
        /// </summary>
        public static Color Blue
        {
            get
            {
                global::System.IntPtr cPtr = NDalicPINVOKE.BLUE_get();
                Color ret = (cPtr == global::System.IntPtr.Zero) ? null : new Color(cPtr, false);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// Get yellow colored Color class
        /// </summary>
        public static Color Yellow
        {
            get
            {
                global::System.IntPtr cPtr = NDalicPINVOKE.YELLOW_get();
                Color ret = (cPtr == global::System.IntPtr.Zero) ? null : new Color(cPtr, false);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// Get magenta colored Color class
        /// </summary>
        public static Color Magenta
        {
            get
            {
                global::System.IntPtr cPtr = NDalicPINVOKE.MAGENTA_get();
                Color ret = (cPtr == global::System.IntPtr.Zero) ? null : new Color(cPtr, false);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// Get cyan colored Color class
        /// </summary>
        public static Color Cyan
        {
            get
            {
                global::System.IntPtr cPtr = NDalicPINVOKE.CYAN_get();
                Color ret = (cPtr == global::System.IntPtr.Zero) ? null : new Color(cPtr, false);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// Get transparent colored Color class
        /// </summary>
        public static Color Transparent
        {
            get
            {
                global::System.IntPtr cPtr = NDalicPINVOKE.TRANSPARENT_get();
                Color ret = (cPtr == global::System.IntPtr.Zero) ? null : new Color(cPtr, false);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// convert Color class to Vector4 class implicitly.
        /// </summary>
        /// <param name="color">A Color to be converted to Vector4</param>
        public static implicit operator Vector4(Color color)
        {
            return new Vector4(color.R, color.G, color.B, color.A);
        }

        /// <summary>
        /// convert Vector4 class to Color class implicitly.
        /// </summary>
        /// <param name="vec">A Vector4 to be converted to Color</param></param>
        public static implicit operator Color(Vector4 vec)
        {
            return new Color(vec.R, vec.G, vec.B, vec.A);
        }

    }

}


