/** Copyright (c) 2017 Samsung Electronics Co., Ltd.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

namespace Tizen.NUI
{
    using System;
    using Tizen.NUI.BaseComponents;

    /// <summary>
    /// Layers provide a mechanism for overlaying groups of actors on top of each other.
    /// </summary>
    public class Layer : Container
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;

        internal Layer(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NDalicPINVOKE.Layer_SWIGUpcast(cPtr), cMemoryOwn)
        {
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Layer obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        /// From the Container base class.

        /// <summary>
        /// Adds a child view to this layer.
        /// </summary>
        /// <seealso cref="Container::Add()">
        /// </seealso>
        public override void Add(View child)
        {
            NDalicPINVOKE.Actor_Add(swigCPtr, View.getCPtr(child));
            if (NDalicPINVOKE.SWIGPendingException.Pending)
                throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Removes a child view from this layer. If the view was not a child of this layer, this is a no-op.
        /// </summary>
        /// <seealso cref="Container::Add()">
        /// </seealso>
        public override void Remove(View child)
        {
            NDalicPINVOKE.Actor_Remove(swigCPtr, View.getCPtr(child));
            if (NDalicPINVOKE.SWIGPendingException.Pending)
                throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Retrieves a child view by the index.
        /// </summary>
        /// <pre>The view has been initialized.</pre>
        /// <param name="index">The index of the child to retrieve.</param>
        /// <returns>The view for the given index or empty handle if children not initialized.</returns>
        public override View GetChildAt(uint index)
        {
            System.IntPtr cPtr = NDalicPINVOKE.Actor_GetChildAt(swigCPtr, index);

            View ret = Registry.GetManagedBaseHandleFromNativePtr(cPtr) as View;

            if (NDalicPINVOKE.SWIGPendingException.Pending)
                throw NDalicPINVOKE.SWIGPendingException.Retrieve();

            return ret ?? null;
        }


        protected override Container GetParent()
        {
            return null;
        }

        protected override uint GetChildCount()
        {
            uint ret = NDalicPINVOKE.Actor_GetChildCount(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending)
                throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        protected override void Dispose(DisposeTypes type)
        {
            if(disposed)
            {
                return;
            }

            if(type == DisposeTypes.Explicit)
            {
                //Called by User
                //Release your own managed resources here.
                //You should release all of your own disposable objects here.
            }

            //Release your own unmanaged resources here.
            //You should not access any managed member here except static instance.
            //because the execution order of Finalizes is non-deterministic.

            if (swigCPtr.Handle != global::System.IntPtr.Zero)
            {
                if (swigCMemOwn)
                {
                    swigCMemOwn = false;
                    NDalicPINVOKE.delete_Layer(swigCPtr);
                }
                swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
            }

            base.Dispose(type);
        }


        internal class Property
        {
            internal static readonly int BEHAVIOR = NDalicPINVOKE.Layer_Property_BEHAVIOR_get();
        }

        /// <summary>
        /// Creates a Layer object.
        /// </summary>
        public Layer() : this(NDalicPINVOKE.Layer_New(), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            if(Window.Instance != null)
            {
                this.SetAnchorPoint(Tizen.NUI.PivotPoint.TopLeft);
                this.SetResizePolicy(ResizePolicyType.FillToParent, DimensionType.AllDimensions);
            }
        }
        internal void SetAnchorPoint(Vector3 anchorPoint)
        {
            NDalicPINVOKE.Actor_SetAnchorPoint(swigCPtr, Vector3.getCPtr(anchorPoint));
            if (NDalicPINVOKE.SWIGPendingException.Pending)
                throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }
        internal void SetResizePolicy(ResizePolicyType policy, DimensionType dimension)
        {
            NDalicPINVOKE.Actor_SetResizePolicy(swigCPtr, (int)policy, (int)dimension);
            if (NDalicPINVOKE.SWIGPendingException.Pending)
                throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }



        [Obsolete("Please do not use! this will be deprecated")]
        public static Layer DownCast(BaseHandle handle)
        {
            Layer ret =  Registry.GetManagedBaseHandleFromNativePtr(handle) as Layer;
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Search through this layer's hierarchy for a view with the given unique ID.
        /// </summary>
        /// <pre>This layer (the parent) has been initialized.</pre>
        /// <remarks>The actor itself is also considered in the search.</remarks>
        /// <param name="id">The id of the child to find</param>
        /// <returns> A handle to the view if found, or an empty handle if not. </returns>
        public View FindChildById(uint id)
        {
            IntPtr cPtr = NDalicPINVOKE.Actor_FindChildById(swigCPtr, id);
            View ret = Registry.GetManagedBaseHandleFromNativePtr(cPtr) as View;

            if (NDalicPINVOKE.SWIGPendingException.Pending)
                throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Queries the depth of the layer.<br>
        /// 0 is the bottommost layer, higher number is on the top.<br>
        /// </summary>
        public uint Depth
        {
            get
            {
                return GetDepth();
            }
        }

        internal uint GetDepth()
        {
            uint ret = NDalicPINVOKE.Layer_GetDepth(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Increments the depth of the layer.
        /// </summary>
        public void Raise()
        {
            NDalicPINVOKE.Layer_Raise(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Decrements the depth of the layer.
        /// </summary>
        public void Lower()
        {
            NDalicPINVOKE.Layer_Lower(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        internal void RaiseAbove(Layer target)
        {
            NDalicPINVOKE.Layer_RaiseAbove(swigCPtr, Layer.getCPtr(target));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        internal void LowerBelow(Layer target)
        {
            NDalicPINVOKE.Layer_LowerBelow(swigCPtr, Layer.getCPtr(target));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Raises the layer to the top.
        /// </summary>
        public void RaiseToTop()
        {
            NDalicPINVOKE.Layer_RaiseToTop(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Lowers the layer to the bottom.
        /// </summary>
        public void LowerToBottom()
        {
            NDalicPINVOKE.Layer_LowerToBottom(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Moves the layer directly above the given layer.<br>
        /// After the call, this layer's depth will be immediately above target.<br>
        /// </summary>
        /// <param name="target">The layer to get on top of.</param>
        public void MoveAbove(Layer target)
        {
            NDalicPINVOKE.Layer_MoveAbove(swigCPtr, Layer.getCPtr(target));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Moves the layer directly below the given layer.<br>
        /// After the call, this layer's depth will be immediately below target.<br>
        /// </summary>
        /// <param name="target">The layer to get below of.</param>
        public void MoveBelow(Layer target)
        {
            NDalicPINVOKE.Layer_MoveBelow(swigCPtr, Layer.getCPtr(target));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        private void SetBehavior(LayerBehavior behavior)
        {
            NDalicPINVOKE.Layer_SetBehavior(swigCPtr, (int)behavior);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        private LayerBehavior GetBehavior()
        {
            Layer.LayerBehavior ret = (Layer.LayerBehavior)NDalicPINVOKE.Layer_GetBehavior(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal void SetSortFunction(SWIGTYPE_p_f_r_q_const__Dali__Vector3__float function)
        {
            NDalicPINVOKE.Layer_SetSortFunction(swigCPtr, SWIGTYPE_p_f_r_q_const__Dali__Vector3__float.getCPtr(function));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        internal void SetTouchConsumed(bool consume)
        {
            NDalicPINVOKE.Layer_SetTouchConsumed(swigCPtr, consume);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        internal bool IsTouchConsumed()
        {
            bool ret = NDalicPINVOKE.Layer_IsTouchConsumed(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal void SetHoverConsumed(bool consume)
        {
            NDalicPINVOKE.Layer_SetHoverConsumed(swigCPtr, consume);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        internal bool IsHoverConsumed()
        {
            bool ret = NDalicPINVOKE.Layer_IsHoverConsumed(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Enumeration for the behavior of the layer.
        /// </summary>
        public enum LayerBehavior
        {
            Layer2D,
            LayerUI = Layer2D,
            Layer3D
        }

        internal enum TreeDepthMultiplier
        {
            TREE_DEPTH_MULTIPLIER = 10000
        }

        /// <summary>
        /// Layer behavior, type String (Layer.LayerBehavior).
        /// </summary>
        public Layer.LayerBehavior Behavior
        {
            get
            {
                return GetBehavior();
            }
            set
            {
                SetBehavior(value);
            }
        }

        /// <summary>
        /// Internal only property to enable or disable clipping, type boolean.
        /// By default, this is false, i.e., the viewport of the layer is the entire window.
        /// </summary>
        internal bool ClippingEnabled
        {
            get
            {
                bool ret = NDalicPINVOKE.Layer_IsClipping(swigCPtr);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
            set
            {
                NDalicPINVOKE.Layer_SetClipping(swigCPtr, value);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        /// <summary>
        /// Sets the viewport (in window coordinates), type rectangle.
        /// The contents of the layer will not be visible outside this box, when ViewportEnabled is true.
        /// </summary>
        public Rectangle Viewport
        {
            get
            {
                if( ClippingEnabled )
                {
                  Rectangle ret = new Rectangle(NDalicPINVOKE.Layer_GetClippingBox(swigCPtr), true);
                  if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                  return ret;
                }
                else
                {
                  // Clipping not enabled so return the window size
                  Size2D windowSize = Window.Instance.Size;
                  Rectangle ret = new Rectangle(0, 0, windowSize.Width, windowSize.Height);
                  return ret;
                }
            }
            set
            {
                NDalicPINVOKE.Layer_SetClippingBox__SWIG_1(swigCPtr, Rectangle.getCPtr(value));
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                ClippingEnabled = true;
            }
        }

        /// <summary>
        /// Retrieves and sets the layer's opacity.<br>
        /// </summary>
        public float Opacity
        {
            get
            {
                float temp = 0.0f;
                GetProperty(View.Property.OPACITY).Get(out temp);
                return temp;
            }
            set
            {
                SetProperty(View.Property.OPACITY, new Tizen.NUI.PropertyValue(value));
            }
        }

        /// <summary>
        /// Retrieves and sets the layer's visibility.
        /// </summary>
        public bool Visibility
        {
            get
            {
                bool temp = false;
                GetProperty(View.Property.VISIBLE).Get(out temp);
                return temp;
            }
            set
            {
                SetProperty(View.Property.VISIBLE, new Tizen.NUI.PropertyValue(value));
            }
        }

        /// <summary>
        /// Get the number of children held by the layer.
        /// </summary>
        public uint ChildCount
        {
            get
            {
                uint ret = NDalicPINVOKE.Actor_GetChildCount(swigCPtr);
                if (NDalicPINVOKE.SWIGPendingException.Pending)
                    throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// Gets or sets the layer's name.
        /// </summary>
        public string Name
        {
            get
            {
                return GetName();
            }
            set
            {
                SetName(value);
            }
        }

        internal string GetName()
        {
            string ret = NDalicPINVOKE.Actor_GetName(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending)
                throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal void SetName(string name)
        {
            NDalicPINVOKE.Actor_SetName(swigCPtr, name);
            if (NDalicPINVOKE.SWIGPendingException.Pending)
                throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

    }
}
