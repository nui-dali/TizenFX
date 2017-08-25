/*
 * Copyright (c) 2017 Samsung Electronics Co., Ltd.
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
    class NDalicManualPINVOKE
    {
        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_new_KeyboardFocusManager")]
        public static extern global::System.IntPtr new_FocusManager();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_delete_KeyboardFocusManager")]
        public static extern void delete_FocusManager(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_KeyboardFocusManager_Get")]
        public static extern global::System.IntPtr FocusManager_Get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_KeyboardFocusManager_SetCurrentFocusActor")]
        public static extern bool FocusManager_SetCurrentFocusActor(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_KeyboardFocusManager_GetCurrentFocusActor")]
        public static extern global::System.IntPtr FocusManager_GetCurrentFocusActor(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_KeyboardFocusManager_MoveFocus")]
        public static extern bool FocusManager_MoveFocus(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_KeyboardFocusManager_ClearFocus")]
        public static extern void FocusManager_ClearFocus(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_KeyboardFocusManager_SetFocusGroupLoop")]
        public static extern void FocusManager_SetFocusGroupLoop(global::System.Runtime.InteropServices.HandleRef jarg1, bool jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_KeyboardFocusManager_GetFocusGroupLoop")]
        public static extern bool FocusManager_GetFocusGroupLoop(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_KeyboardFocusManager_SetAsFocusGroup")]
        public static extern void FocusManager_SetAsFocusGroup(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2, bool jarg3);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_KeyboardFocusManager_IsFocusGroup")]
        public static extern bool FocusManager_IsFocusGroup(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_KeyboardFocusManager_GetFocusGroup")]
        public static extern global::System.IntPtr FocusManager_GetFocusGroup(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_KeyboardFocusManager_SetFocusIndicatorActor")]
        public static extern void FocusManager_SetFocusIndicatorActor(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_KeyboardFocusManager_GetFocusIndicatorActor")]
        public static extern global::System.IntPtr FocusManager_GetFocusIndicatorActor(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_KeyboardFocusManager_MoveFocusBackward")]
        public static extern void FocusManager_MoveFocusBackward(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_KeyboardFocusManager_PreFocusChangeSignal")]
        public static extern global::System.IntPtr FocusManager_PreFocusChangeSignal(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_KeyboardFocusManager_FocusChangedSignal")]
        public static extern global::System.IntPtr FocusManager_FocusChangedSignal(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_KeyboardFocusManager_FocusGroupChangedSignal")]
        public static extern global::System.IntPtr FocusManager_FocusGroupChangedSignal(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_KeyboardFocusManager_FocusedActorEnterKeySignal")]
        public static extern global::System.IntPtr FocusManager_FocusedActorEnterKeySignal(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_KeyboardPreFocusChangeSignal_Empty")]
        public static extern bool PreFocusChangeSignal_Empty(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_KeyboardPreFocusChangeSignal_GetConnectionCount")]
        public static extern uint PreFocusChangeSignal_GetConnectionCount(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_KeyboardPreFocusChangeSignal_Connect")]
        public static extern void PreFocusChangeSignal_Connect(global::System.Runtime.InteropServices.HandleRef jarg1, FocusManager.PreFocusChangeEventCallback delegate1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_KeyboardPreFocusChangeSignal_Disconnect")]
        public static extern void PreFocusChangeSignal_Disconnect(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_KeyboardPreFocusChangeSignal_Emit")]
        public static extern global::System.IntPtr PreFocusChangeSignal_Emit(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2, global::System.Runtime.InteropServices.HandleRef jarg3, int jarg4);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_new_KeyboardPreFocusChangeSignal")]
        public static extern global::System.IntPtr new_PreFocusChangeSignal();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_delete_KeyboardPreFocusChangeSignal")]
        public static extern void delete_PreFocusChangeSignal(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_KeyboardFocusManager_SWIGUpcast")]
        public static extern global::System.IntPtr FocusManager_SWIGUpcast(global::System.IntPtr jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ViewWrapperImpl_CONTROL_BEHAVIOUR_FLAG_COUNT_get")]
        public static extern int ViewWrapperImpl_CONTROL_BEHAVIOUR_FLAG_COUNT_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_new_ViewWrapperImpl")]
        public static extern global::System.IntPtr new_ViewWrapperImpl(int jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ViewWrapperImpl_New")]
        public static extern global::System.IntPtr ViewWrapperImpl_New(string jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_delete_ViewWrapperImpl")]
        public static extern void delete_ViewWrapperImpl(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ViewWrapperImpl_director_connect")]
        public static extern void ViewWrapperImpl_director_connect(global::System.Runtime.InteropServices.HandleRef jarg1, ViewWrapperImpl.DelegateViewWrapperImpl_0 delegate0, ViewWrapperImpl.DelegateViewWrapperImpl_1 delegate1, ViewWrapperImpl.DelegateViewWrapperImpl_2 delegate2, ViewWrapperImpl.DelegateViewWrapperImpl_3 delegate3, ViewWrapperImpl.DelegateViewWrapperImpl_4 delegate4, ViewWrapperImpl.DelegateViewWrapperImpl_5 delegate5, ViewWrapperImpl.DelegateViewWrapperImpl_6 delegate6, ViewWrapperImpl.DelegateViewWrapperImpl_7 delegate7, ViewWrapperImpl.DelegateViewWrapperImpl_8 delegate8, ViewWrapperImpl.DelegateViewWrapperImpl_9 delegate9, ViewWrapperImpl.DelegateViewWrapperImpl_10 delegate10, ViewWrapperImpl.DelegateViewWrapperImpl_11 delegate11, ViewWrapperImpl.DelegateViewWrapperImpl_12 delegate12, ViewWrapperImpl.DelegateViewWrapperImpl_13 delegate13, ViewWrapperImpl.DelegateViewWrapperImpl_14 delegate14, ViewWrapperImpl.DelegateViewWrapperImpl_15 delegate15, ViewWrapperImpl.DelegateViewWrapperImpl_16 delegate16, ViewWrapperImpl.DelegateViewWrapperImpl_17 delegate17, ViewWrapperImpl.DelegateViewWrapperImpl_18 delegate18, ViewWrapperImpl.DelegateViewWrapperImpl_19 delegate19, ViewWrapperImpl.DelegateViewWrapperImpl_20 delegate20, ViewWrapperImpl.DelegateViewWrapperImpl_21 delegate21, ViewWrapperImpl.DelegateViewWrapperImpl_22 delegate22, ViewWrapperImpl.DelegateViewWrapperImpl_23 delegate23, ViewWrapperImpl.DelegateViewWrapperImpl_24 delegate24, ViewWrapperImpl.DelegateViewWrapperImpl_25 delegate25, ViewWrapperImpl.DelegateViewWrapperImpl_26 delegate26, ViewWrapperImpl.DelegateViewWrapperImpl_27 delegate27, ViewWrapperImpl.DelegateViewWrapperImpl_28 delegate28, ViewWrapperImpl.DelegateViewWrapperImpl_29 delegate29, ViewWrapperImpl.DelegateViewWrapperImpl_30 delegate30, ViewWrapperImpl.DelegateViewWrapperImpl_31 delegate31, ViewWrapperImpl.DelegateViewWrapperImpl_32 delegate32, ViewWrapperImpl.DelegateViewWrapperImpl_33 delegate33, ViewWrapperImpl.DelegateViewWrapperImpl_34 delegate34, ViewWrapperImpl.DelegateViewWrapperImpl_35 delegate35, ViewWrapperImpl.DelegateViewWrapperImpl_36 delegate36, ViewWrapperImpl.DelegateViewWrapperImpl_37 delegate37, ViewWrapperImpl.DelegateViewWrapperImpl_38 delegate38, ViewWrapperImpl.DelegateViewWrapperImpl_39 delegate39, ViewWrapperImpl.DelegateViewWrapperImpl_40 delegate40);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_GetControlWrapperImpl__SWIG_0")]
        public static extern global::System.IntPtr GetControlWrapperImpl__SWIG_0(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ViewWrapper_New")]
        public static extern global::System.IntPtr ViewWrapper_New(string jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_new_ViewWrapper__SWIG_0")]
        public static extern global::System.IntPtr new_ViewWrapper__SWIG_0();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_delete_ViewWrapper")]
        public static extern void delete_ViewWrapper(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_new_ViewWrapper__SWIG_1")]
        public static extern global::System.IntPtr new_ViewWrapper__SWIG_1(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ViewWrapper_Assign")]
        public static extern global::System.IntPtr ViewWrapper_Assign(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ViewWrapper_DownCast")]
        public static extern global::System.IntPtr ViewWrapper_DownCast(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ViewWrapperImpl_SWIGUpcast")]
        public static extern global::System.IntPtr ViewWrapperImpl_SWIGUpcast(global::System.IntPtr jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ViewWrapper_SWIGUpcast")]
        public static extern global::System.IntPtr ViewWrapper_SWIGUpcast(global::System.IntPtr jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_ViewWrapperImpl_RelayoutRequest")]
        public static extern void ViewWrapperImpl_RelayoutRequest(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_ViewWrapperImpl_GetHeightForWidthBase")]
        public static extern float ViewWrapperImpl_GetHeightForWidthBase(global::System.Runtime.InteropServices.HandleRef jarg1, float jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_ViewWrapperImpl_GetWidthForHeightBase")]
        public static extern float ViewWrapperImpl_GetWidthForHeightBase(global::System.Runtime.InteropServices.HandleRef jarg1, float jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_ViewWrapperImpl_CalculateChildSizeBase")]
        public static extern float ViewWrapperImpl_CalculateChildSizeBase(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2, int jarg3);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_ViewWrapperImpl_RelayoutDependentOnChildrenBase__SWIG_0")]
        public static extern bool ViewWrapperImpl_RelayoutDependentOnChildrenBase__SWIG_0(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_ViewWrapperImpl_RelayoutDependentOnChildrenBase__SWIG_1")]
        public static extern bool ViewWrapperImpl_RelayoutDependentOnChildrenBase__SWIG_1(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_ViewWrapperImpl_RegisterVisual__SWIG_0")]
        public static extern void ViewWrapperImpl_RegisterVisual__SWIG_0(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, global::System.Runtime.InteropServices.HandleRef jarg3);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_ViewWrapperImpl_RegisterVisual__SWIG_1")]
        public static extern void ViewWrapperImpl_RegisterVisual__SWIG_1(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, global::System.Runtime.InteropServices.HandleRef jarg3, bool jarg4);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_ViewWrapperImpl_UnregisterVisual")]
        public static extern void ViewWrapperImpl_UnregisterVisual(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_ViewWrapperImpl_GetVisual")]
        public static extern global::System.IntPtr ViewWrapperImpl_GetVisual(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_ViewWrapperImpl_EnableVisual")]
        public static extern void ViewWrapperImpl_EnableVisual(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, bool jarg3);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_ViewWrapperImpl_IsVisualEnabled")]
        public static extern bool ViewWrapperImpl_IsVisualEnabled(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_ViewWrapperImpl_CreateTransition")]
        public static extern global::System.IntPtr ViewWrapperImpl_CreateTransition(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_View_CreateTransition")]
        public static extern global::System.IntPtr View_CreateTransition(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_ViewWrapperImpl_EmitKeyInputFocusSignal")]
        public static extern void ViewWrapperImpl_EmitKeyInputFocusSignal(global::System.Runtime.InteropServices.HandleRef jarg1, bool jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ViewWrapperImpl_ApplyThemeStyle")]
        public static extern void ViewWrapperImpl_ApplyThemeStyle(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_new_EventThreadCallback")]
        public static extern global::System.IntPtr new_EventThreadCallback(EventThreadCallback.CallbackDelegate delegate1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_delete_EventThreadCallback")]
        public static extern void delete_EventThreadCallback(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_EventThreadCallback_Trigger")]
        public static extern void EventThreadCallback_Trigger(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Actor_Property_SIBLING_ORDER_get")]
        public static extern int Actor_Property_SIBLING_ORDER_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Actor_Property_OPACITY_get")]
        public static extern int Actor_Property_OPACITY_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Actor_Property_SCREEN_POSITION_get")]
        public static extern int Actor_Property_SCREEN_POSITION_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Actor_Property_POSITION_USES_ANCHOR_POINT_get")]
        public static extern int Actor_Property_POSITION_USES_ANCHOR_POINT_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_View_Property_TOOLTIP_get")]
        public static extern int View_Property_TOOLTIP_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_View_Property_STATE_get")]
        public static extern int View_Property_STATE_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_View_Property_SUB_STATE_get")]
        public static extern int View_Property_SUB_STATE_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_View_Property_LEFT_FOCUSABLE_ACTOR_ID_get")]
        public static extern int View_Property_LEFT_FOCUSABLE_ACTOR_ID_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_View_Property_RIGHT_FOCUSABLE_ACTOR_ID_get")]
        public static extern int View_Property_RIGHT_FOCUSABLE_ACTOR_ID_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_View_Property_UP_FOCUSABLE_ACTOR_ID_get")]
        public static extern int View_Property_UP_FOCUSABLE_ACTOR_ID_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_View_Property_DOWN_FOCUSABLE_ACTOR_ID_get")]
        public static extern int View_Property_DOWN_FOCUSABLE_ACTOR_ID_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_ItemView_Property_LAYOUT_get")]
        public static extern int ItemView_Property_LAYOUT_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Button_Property_UNSELECTED_VISUAL_get")]
        public static extern int Button_Property_UNSELECTED_VISUAL_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Button_Property_SELECTED_VISUAL_get")]
        public static extern int Button_Property_SELECTED_VISUAL_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Button_Property_DISABLED_SELECTED_VISUAL_get")]
        public static extern int Button_Property_DISABLED_SELECTED_VISUAL_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Button_Property_DISABLED_UNSELECTED_VISUAL_get")]
        public static extern int Button_Property_DISABLED_UNSELECTED_VISUAL_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Button_Property_UNSELECTED_BACKGROUND_VISUAL_get")]
        public static extern int Button_Property_UNSELECTED_BACKGROUND_VISUAL_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Button_Property_SELECTED_BACKGROUND_VISUAL_get")]
        public static extern int Button_Property_SELECTED_BACKGROUND_VISUAL_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Button_Property_DISABLED_UNSELECTED_BACKGROUND_VISUAL_get")]
        public static extern int Button_Property_DISABLED_UNSELECTED_BACKGROUND_VISUAL_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Button_Property_DISABLED_SELECTED_BACKGROUND_VISUAL_get")]
        public static extern int Button_Property_DISABLED_SELECTED_BACKGROUND_VISUAL_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Button_Property_LABEL_RELATIVE_ALIGNMENT_get")]
        public static extern int Button_Property_LABEL_RELATIVE_ALIGNMENT_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Button_Property_LABEL_PADDING_get")]
        public static extern int Button_Property_LABEL_PADDING_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Button_Property_VISUAL_PADDING_get")]
        public static extern int Button_Property_VISUAL_PADDING_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Visual_Property_TRANSFORM_get")]
        public static extern int Visual_Property_TRANSFORM_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Visual_Property_PREMULTIPLIED_ALPHA_get")]
        public static extern int Visual_Property_PREMULTIPLIED_ALPHA_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Visual_Property_MIX_COLOR_get")]
        public static extern int Visual_Property_MIX_COLOR_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Image_Visual_BORDER_get")]
        public static extern int Image_Visual_BORDER_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint = "CSharp_Dali_NativeVersionCheck")]
        public static extern bool NativeVersionCheck(ref int ver1, ref int ver2, ref int ver3);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint = "CSharp_Dali_GrabKeyTopmost")]
        public static extern bool GrabKeyTopmost(System.IntPtr Window, int DaliKey);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint = "CSharp_Dali_UngrabKeyTopmost")]
        public static extern bool UngrabKeyTopmost(System.IntPtr Window, int DaliKey);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint = "CSharp_Dali_GrabKey")]
        public static extern bool GrabKey(System.IntPtr Window, int DaliKey, int GrabMode);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint = "CSharp_Dali_UngrabKey")]
        public static extern bool UngrabKey(System.IntPtr Window, int DaliKey);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint = "CSharp_Dali_GetNativeWindowHandler")]
        public static extern System.IntPtr GetNativeWindowHandler(System.IntPtr Window);

        //////////////////////ImfManager

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_SWIGUpcast")]
        public static extern global::System.IntPtr ImfManager_SWIGUpcast(global::System.IntPtr jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_new_ImfManager_ImfEventData__SWIG_0")]
        public static extern global::System.IntPtr new_ImfManager_ImfEventData__SWIG_0();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_new_ImfManager_ImfEventData__SWIG_1")]
        public static extern global::System.IntPtr new_ImfManager_ImfEventData__SWIG_1(int jarg1, string jarg2, int jarg3, int jarg4);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_ImfEventData_predictiveString_set")]
        public static extern void ImfManager_ImfEventData_predictiveString_set(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_ImfEventData_predictiveString_get")]
        public static extern string ImfManager_ImfEventData_predictiveString_get(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_ImfEventData_eventName_set")]
        public static extern void ImfManager_ImfEventData_eventName_set(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_ImfEventData_eventName_get")]
        public static extern int ImfManager_ImfEventData_eventName_get(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_ImfEventData_cursorOffset_set")]
        public static extern void ImfManager_ImfEventData_cursorOffset_set(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_ImfEventData_cursorOffset_get")]
        public static extern int ImfManager_ImfEventData_cursorOffset_get(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_ImfEventData_numberOfChars_set")]
        public static extern void ImfManager_ImfEventData_numberOfChars_set(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_ImfEventData_numberOfChars_get")]
        public static extern int ImfManager_ImfEventData_numberOfChars_get(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_delete_ImfManager_ImfEventData")]
        public static extern void delete_ImfManager_ImfEventData(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_new_ImfManager_ImfCallbackData__SWIG_0")]
        public static extern global::System.IntPtr new_ImfManager_ImfCallbackData__SWIG_0();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_new_ImfManager_ImfCallbackData__SWIG_1")]
        public static extern global::System.IntPtr new_ImfManager_ImfCallbackData__SWIG_1(bool jarg1, int jarg2, string jarg3, bool jarg4);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_ImfCallbackData_currentText_set")]
        public static extern void ImfManager_ImfCallbackData_currentText_set(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_ImfCallbackData_currentText_get")]
        public static extern string ImfManager_ImfCallbackData_currentText_get(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_ImfCallbackData_cursorPosition_set")]
        public static extern void ImfManager_ImfCallbackData_cursorPosition_set(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_ImfCallbackData_cursorPosition_get")]
        public static extern int ImfManager_ImfCallbackData_cursorPosition_get(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_ImfCallbackData_update_set")]
        public static extern void ImfManager_ImfCallbackData_update_set(global::System.Runtime.InteropServices.HandleRef jarg1, bool jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_ImfCallbackData_update_get")]
        public static extern bool ImfManager_ImfCallbackData_update_get(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_ImfCallbackData_preeditResetRequired_set")]
        public static extern void ImfManager_ImfCallbackData_preeditResetRequired_set(global::System.Runtime.InteropServices.HandleRef jarg1, bool jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_ImfCallbackData_preeditResetRequired_get")]
        public static extern bool ImfManager_ImfCallbackData_preeditResetRequired_get(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_delete_ImfManager_ImfCallbackData")]
        public static extern void delete_ImfManager_ImfCallbackData(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_Get")]
        public static extern global::System.IntPtr ImfManager_Get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_Activate")]
        public static extern void ImfManager_Activate(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_Deactivate")]
        public static extern void ImfManager_Deactivate(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_RestoreAfterFocusLost")]
        public static extern bool ImfManager_RestoreAfterFocusLost(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_SetRestoreAfterFocusLost")]
        public static extern void ImfManager_SetRestoreAfterFocusLost(global::System.Runtime.InteropServices.HandleRef jarg1, bool jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_Reset")]
        public static extern void ImfManager_Reset(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_NotifyCursorPosition")]
        public static extern void ImfManager_NotifyCursorPosition(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_SetCursorPosition")]
        public static extern void ImfManager_SetCursorPosition(global::System.Runtime.InteropServices.HandleRef jarg1, uint jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_GetCursorPosition")]
        public static extern uint ImfManager_GetCursorPosition(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_SetSurroundingText")]
        public static extern void ImfManager_SetSurroundingText(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_GetSurroundingText")]
        public static extern string ImfManager_GetSurroundingText(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_NotifyTextInputMultiLine")]
        public static extern void ImfManager_NotifyTextInputMultiLine(global::System.Runtime.InteropServices.HandleRef jarg1, bool jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_GetTextDirection")]
        public static extern int ImfManager_GetTextDirection(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_GetInputMethodArea")]
        public static extern global::System.IntPtr ImfManager_GetInputMethodArea(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_ApplyOptions")]
        public static extern void ImfManager_ApplyOptions(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_SetInputPanelUserData")]
        public static extern void ImfManager_SetInputPanelUserData(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_GetInputPanelUserData")]
        public static extern void ImfManager_GetInputPanelUserData(global::System.Runtime.InteropServices.HandleRef jarg1, out string jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_GetInputPanelState")]
        public static extern int ImfManager_GetInputPanelState(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_SetReturnKeyState")]
        public static extern void ImfManager_SetReturnKeyState(global::System.Runtime.InteropServices.HandleRef jarg1, bool jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_AutoEnableInputPanel")]
        public static extern void ImfManager_AutoEnableInputPanel(global::System.Runtime.InteropServices.HandleRef jarg1, bool jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_ShowInputPanel")]
        public static extern void ImfManager_ShowInputPanel(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_HideInputPanel")]
        public static extern void ImfManager_HideInputPanel(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_GetKeyboardType")]
        public static extern int ImfManager_GetKeyboardType(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_GetInputPanelLocale")]
        public static extern string ImfManager_GetInputPanelLocale(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_ActivatedSignal")]
        public static extern global::System.IntPtr ImfManager_ActivatedSignal(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_EventReceivedSignal")]
        public static extern global::System.IntPtr ImfManager_EventReceivedSignal(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_StatusChangedSignal")]
        public static extern global::System.IntPtr ImfManager_StatusChangedSignal(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_ResizedSignal")]
        public static extern global::System.IntPtr ImfManager_ResizedSignal(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_LanguageChangedSignal")]
        public static extern global::System.IntPtr ImfManager_LanguageChangedSignal(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfManager_KeyboardTypeChangedSignal")]
        public static extern global::System.IntPtr ImfManager_KeyboardTypeChangedSignal(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_new_ImfManager")]
        public static extern global::System.IntPtr new_ImfManager();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_delete_ImfManager")]
        public static extern void delete_ImfManager(global::System.Runtime.InteropServices.HandleRef jarg1);

        ////////////////////// ImfManager signals
        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ActivatedSignalType_Empty")]
        public static extern bool ActivatedSignalType_Empty(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ActivatedSignalType_GetConnectionCount")]
        public static extern uint ActivatedSignalType_GetConnectionCount(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ActivatedSignalType_Connect")]
        public static extern void ActivatedSignalType_Connect(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ActivatedSignalType_Disconnect")]
        public static extern void ActivatedSignalType_Disconnect(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ActivatedSignalType_Emit")]
        public static extern void ActivatedSignalType_Emit(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_new_ActivatedSignalType")]
        public static extern global::System.IntPtr new_ActivatedSignalType();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_delete_ActivatedSignalType")]
        public static extern void delete_ActivatedSignalType(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfEventSignalType_Empty")]
        public static extern bool ImfEventSignalType_Empty(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfEventSignalType_GetConnectionCount")]
        public static extern uint ImfEventSignalType_GetConnectionCount(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfEventSignalType_Connect")]
        public static extern void ImfEventSignalType_Connect(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfEventSignalType_Disconnect")]
        public static extern void ImfEventSignalType_Disconnect(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfEventSignalType_Emit")]
        public static extern global::System.IntPtr ImfEventSignalType_Emit(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2, global::System.Runtime.InteropServices.HandleRef jarg3);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_new_ImfEventSignalType")]
        public static extern global::System.IntPtr new_ImfEventSignalType();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_delete_ImfEventSignalType")]
        public static extern void delete_ImfEventSignalType(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_new_ImfVoidSignalType")]
        public static extern global::System.IntPtr new_ImfVoidSignalType();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_delete_ImfVoidSignalType")]
        public static extern void delete_ImfVoidSignalType(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfVoidSignalType_Empty")]
        public static extern bool ImfVoidSignalType_Empty(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfVoidSignalType_GetConnectionCount")]
        public static extern uint ImfVoidSignalType_GetConnectionCount(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfVoidSignalType_Connect__SWIG_0")]
        public static extern void ImfVoidSignalType_Connect__SWIG_0(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfVoidSignalType_Disconnect")]
        public static extern void ImfVoidSignalType_Disconnect(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfVoidSignalType_Connect__SWIG_4")]
        public static extern void ImfVoidSignalType_Connect__SWIG_4(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2, global::System.Runtime.InteropServices.HandleRef jarg3);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ImfVoidSignalType_Emit")]
        public static extern void ImfVoidSignalType_Emit(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_StatusSignalType_Empty")]
        public static extern bool StatusSignalType_Empty(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_StatusSignalType_GetConnectionCount")]
        public static extern uint StatusSignalType_GetConnectionCount(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_StatusSignalType_Connect")]
        public static extern void StatusSignalType_Connect(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_StatusSignalType_Disconnect")]
        public static extern void StatusSignalType_Disconnect(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_StatusSignalType_Emit")]
        public static extern void StatusSignalType_Emit(global::System.Runtime.InteropServices.HandleRef jarg1, bool jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_new_StatusSignalType")]
        public static extern global::System.IntPtr new_StatusSignalType();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_delete_StatusSignalType")]
        public static extern void delete_StatusSignalType(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_KeyboardTypeSignalType_Empty")]
        public static extern bool KeyboardTypeSignalType_Empty(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_KeyboardTypeSignalType_GetConnectionCount")]
        public static extern uint KeyboardTypeSignalType_GetConnectionCount(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_KeyboardTypeSignalType_Connect")]
        public static extern void KeyboardTypeSignalType_Connect(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_KeyboardTypeSignalType_Disconnect")]
        public static extern void KeyboardTypeSignalType_Disconnect(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_KeyboardTypeSignalType_Emit")]
        public static extern void KeyboardTypeSignalType_Emit(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_new_KeyboardTypeSignalType")]
        public static extern global::System.IntPtr new_KeyboardTypeSignalType();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_delete_KeyboardTypeSignalType")]
        public static extern void delete_KeyboardTypeSignalType(global::System.Runtime.InteropServices.HandleRef jarg1);

        //////////////////////InputMethodOptions

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_new_InputMethodOptions")]
        public static extern global::System.IntPtr new_InputMethodOptions();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_InputMethodOptions_IsPassword")]
        public static extern bool InputMethodOptions_IsPassword(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_InputMethodOptions_ApplyProperty")]
        public static extern void InputMethodOptions_ApplyProperty(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_InputMethodOptions_RetrieveProperty")]
        public static extern void InputMethodOptions_RetrieveProperty(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_InputMethodOptions_CompareAndSet")]
        public static extern bool InputMethodOptions_CompareAndSet(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, global::System.Runtime.InteropServices.HandleRef jarg3, global::System.Runtime.InteropServices.HandleRef jarg4);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_delete_InputMethodOptions")]
        public static extern void delete_InputMethodOptions(global::System.Runtime.InteropServices.HandleRef jarg1);


        /////////////////////////////////////////////////////////////
        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_TextEditor_Property_SMOOTH_SCROLL_get")]
        public static extern int TextEditor_Property_SMOOTH_SCROLL_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_TextEditor_Property_SMOOTH_SCROLL_DURATION_get")]
        public static extern int TextEditor_Property_SMOOTH_SCROLL_DURATION_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_TextEditor_Property_ENABLE_SCROLL_BAR_get")]
        public static extern int TextEditor_Property_ENABLE_SCROLL_BAR_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_TextEditor_Property_SCROLL_BAR_SHOW_DURATION_get")]
        public static extern int TextEditor_Property_SCROLL_BAR_SHOW_DURATION_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_TextEditor_Property_SCROLL_BAR_FADE_DURATION_get")]
        public static extern int TextEditor_Property_SCROLL_BAR_FADE_DURATION_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_TextEditor_Property_PIXEL_SIZE_get")]
        public static extern int TextEditor_Property_PIXEL_SIZE_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_TextEditor_Property_LINE_COUNT_get")]
        public static extern int TextEditor_Property_LINE_COUNT_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_TextEditor_Property_PLACEHOLDER_TEXT_get")]
        public static extern int TextEditor_Property_PLACEHOLDER_TEXT_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_TextEditor_Property_PLACEHOLDER_TEXT_COLOR_get")]
        public static extern int TextEditor_Property_PLACEHOLDER_TEXT_COLOR_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_TextEditor_Property_ENABLE_SELECTION_get")]
        public static extern int TextEditor_Property_ENABLE_SELECTION_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_TextEditor_Property_PLACEHOLDER_get")]
        public static extern int TextEditor_Property_PLACEHOLDER_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_TextEditor_Property_LINE_WRAP_MODE_get")]
        public static extern int TextEditor_Property_LINE_WRAP_MODE_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_TextField_Property_HIDDEN_INPUT_SETTINGS_get")]
        public static extern int TextField_Property_HIDDEN_INPUT_SETTINGS_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_TextField_Property_PIXEL_SIZE_get")]
        public static extern int TextField_Property_PIXEL_SIZE_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_TextField_Property_ENABLE_SELECTION_get")]
        public static extern int TextField_Property_ENABLE_SELECTION_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_TextField_Property_PLACEHOLDER_get")]
        public static extern int TextField_Property_PLACEHOLDER_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_TextLabel_Property_PIXEL_SIZE_get")]
        public static extern int TextLabel_Property_PIXEL_SIZE_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_TextLabel_Property_ELLIPSIS_get")]
        public static extern int TextLabel_Property_ELLIPSIS_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint = "CSharp_TextLabel_Property_AUTO_SCROLL_STOP_MODE_get")]
        public static extern int TextLabel_Property_AUTO_SCROLL_STOP_MODE_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint = "CSharp_TextLabel_Property_AUTO_SCROLL_LOOP_DELAY_get")]
        public static extern int TextLabel_Property_AUTO_SCROLL_LOOP_DELAY_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_TextLabel_Property_LINE_COUNT_get")]
        public static extern int TextLabel_Property_LINE_COUNT_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_TextLabel_Property_LINE_WRAP_MODE_get")]
        public static extern int TextLabel_Property_LINE_WRAP_MODE_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint = "CSharp_HIDDENINPUT_PROPERTY_MODE_get")]
        public static extern int HIDDENINPUT_PROPERTY_MODE_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint = "CSharp_HIDDENINPUT_PROPERTY_SUBSTITUTE_CHARACTER_get")]
        public static extern int HIDDENINPUT_PROPERTY_SUBSTITUTE_CHARACTER_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint = "CSharp_HIDDENINPUT_PROPERTY_SUBSTITUTE_COUNT_get")]
        public static extern int HIDDENINPUT_PROPERTY_SUBSTITUTE_COUNT_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint = "CSharp_HIDDENINPUT_PROPERTY_SHOW_DURATION_get")]
        public static extern int HIDDENINPUT_PROPERTY_SHOW_DURATION_get();
        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_TtsPlayer_SWIGUpcast")]
        public static extern global::System.IntPtr TtsPlayer_SWIGUpcast(global::System.IntPtr jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_new_TtsPlayer__SWIG_0")]
        public static extern global::System.IntPtr new_TtsPlayer__SWIG_0();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_TtsPlayer_Get__SWIG_0")]
        public static extern global::System.IntPtr TtsPlayer_Get__SWIG_0(int jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_TtsPlayer_Get__SWIG_1")]
        public static extern global::System.IntPtr TtsPlayer_Get__SWIG_1();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_delete_TtsPlayer")]
        public static extern void delete_TtsPlayer(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_new_TtsPlayer__SWIG_1")]
        public static extern global::System.IntPtr new_TtsPlayer__SWIG_1(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_TtsPlayer_Assign")]
        public static extern global::System.IntPtr TtsPlayer_Assign(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_TtsPlayer_Play")]
        public static extern void TtsPlayer_Play(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_TtsPlayer_Stop")]
        public static extern void TtsPlayer_Stop(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_TtsPlayer_Pause")]
        public static extern void TtsPlayer_Pause(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_TtsPlayer_Resume")]
        public static extern void TtsPlayer_Resume(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_TtsPlayer_GetState")]
        public static extern int TtsPlayer_GetState(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_TtsPlayer_StateChangedSignal")]
        public static extern global::System.IntPtr TtsPlayer_StateChangedSignal(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_StateChangedSignalType_Empty")]
        public static extern bool StateChangedSignalType_Empty(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_StateChangedSignalType_GetConnectionCount")]
        public static extern uint StateChangedSignalType_GetConnectionCount(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_StateChangedSignalType_Connect")]
        public static extern void StateChangedSignalType_Connect(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_StateChangedSignalType_Disconnect")]
        public static extern void StateChangedSignalType_Disconnect(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_StateChangedSignalType_Emit")]
        public static extern void StateChangedSignalType_Emit(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, int jarg3);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_new_StateChangedSignalType")]
        public static extern global::System.IntPtr new_StateChangedSignalType();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_delete_StateChangedSignalType")]
        public static extern void delete_StateChangedSignalType(global::System.Runtime.InteropServices.HandleRef jarg1);

        //manual pinvoke for text-editor ScrollStateChangedSignal
        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_TextEditor_ScrollStateChangedSignal")]
        public static extern global::System.IntPtr TextEditor_ScrollStateChangedSignal(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ScrollStateChangedSignal_Empty")]
        public static extern bool ScrollStateChangedSignal_Empty(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ScrollStateChangedSignal_GetConnectionCount")]
        public static extern uint ScrollStateChangedSignal_GetConnectionCount(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ScrollStateChangedSignal_Connect")]
        public static extern void ScrollStateChangedSignal_Connect(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ScrollStateChangedSignal_Disconnect")]
        public static extern void ScrollStateChangedSignal_Disconnect(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ScrollStateChangedSignal_Emit")]
        public static extern void ScrollStateChangedSignal_Emit(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_new_ScrollStateChangedSignal")]
        public static extern global::System.IntPtr new_ScrollStateChangedSignal();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_delete_ScrollStateChangedSignal")]
        public static extern void delete_ScrollStateChangedSignal(global::System.Runtime.InteropServices.HandleRef jarg1);

        // For windows resized signal
        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_Window_ResizedSignal")]
        public static extern global::System.IntPtr Window_ResizedSignal(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ResizedSignal_Empty")]
        public static extern bool ResizedSignal_Empty(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ResizedSignal_GetConnectionCount")]
        public static extern uint ResizedSignal_GetConnectionCount(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ResizedSignal_Connect")]
        public static extern void ResizedSignal_Connect(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ResizedSignal_Disconnect")]
        public static extern void ResizedSignal_Disconnect(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_ResizedSignal_Emit")]
        public static extern void ResizedSignal_Emit(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_new_ResizedSignal")]
        public static extern global::System.IntPtr new_ResizedSignal();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_delete_ResizedSignal")]
        public static extern void delete_ResizedSignal(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_Window_SetSize")]
        public static extern void SetSize(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_Window_GetSize")]
        public static extern global::System.IntPtr GetSize(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_Window_SetPosition")]
        public static extern void SetPosition(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_Window_GetPosition")]
        public static extern global::System.IntPtr GetPosition(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_Adaptor_FeedKeyEvent")]
        public static extern void Window_FeedKeyEvent(global::System.Runtime.InteropServices.HandleRef jarg1);

        //for widget view
        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_WidgetView_Property_WIDGET_ID_get")]
        public static extern int WidgetView_Property_WIDGET_ID_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_WidgetView_Property_INSTANCE_ID_get")]
        public static extern int WidgetView_Property_INSTANCE_ID_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_WidgetView_Property_CONTENT_INFO_get")]
        public static extern int WidgetView_Property_CONTENT_INFO_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_WidgetView_Property_TITLE_get")]
        public static extern int WidgetView_Property_TITLE_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_WidgetView_Property_UPDATE_PERIOD_get")]
        public static extern int WidgetView_Property_UPDATE_PERIOD_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_WidgetView_Property_PREVIEW_get")]
        public static extern int WidgetView_Property_PREVIEW_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_WidgetView_Property_LOADING_TEXT_get")]
        public static extern int WidgetView_Property_LOADING_TEXT_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_WidgetView_Property_WIDGET_STATE_FAULTED_get")]
        public static extern int WidgetView_Property_WIDGET_STATE_FAULTED_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_WidgetView_Property_PERMANENT_DELETE_get")]
        public static extern int WidgetView_Property_PERMANENT_DELETE_get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_new_WidgetView_Property")]
        public static extern global::System.IntPtr new_WidgetView_Property();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_delete_WidgetView_Property")]
        public static extern void delete_WidgetView_Property(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_WidgetView_New")]
        public static extern global::System.IntPtr WidgetView_New(string jarg1, string jarg2, int jarg3, int jarg4, float jarg5);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_WidgetView_DownCast")]
        public static extern global::System.IntPtr WidgetView_DownCast(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_new_WidgetView__SWIG_0")]
        public static extern global::System.IntPtr new_WidgetView__SWIG_0();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_new_WidgetView__SWIG_1")]
        public static extern global::System.IntPtr new_WidgetView__SWIG_1(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_WidgetView_Assign")]
        public static extern global::System.IntPtr WidgetView_Assign(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_delete_WidgetView")]
        public static extern void delete_WidgetView(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_WidgetView_PauseWidget")]
        public static extern bool WidgetView_PauseWidget(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_WidgetView_ResumeWidget")]
        public static extern bool WidgetView_ResumeWidget(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_WidgetView_CancelTouchEvent")]
        public static extern bool WidgetView_CancelTouchEvent(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_WidgetView_ActivateFaultedWidget")]
        public static extern void WidgetView_ActivateFaultedWidget(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_WidgetView_WidgetAddedSignal")]
        public static extern global::System.IntPtr WidgetView_WidgetAddedSignal(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_WidgetView_WidgetDeletedSignal")]
        public static extern global::System.IntPtr WidgetView_WidgetDeletedSignal(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_WidgetView_WidgetCreationAbortedSignal")]
        public static extern global::System.IntPtr WidgetView_WidgetCreationAbortedSignal(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_WidgetView_WidgetContentUpdatedSignal")]
        public static extern global::System.IntPtr WidgetView_WidgetContentUpdatedSignal(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_WidgetView_WidgetUpdatePeriodChangedSignal")]
        public static extern global::System.IntPtr WidgetView_WidgetUpdatePeriodChangedSignal(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_WidgetView_WidgetFaultedSignal")]
        public static extern global::System.IntPtr WidgetView_WidgetFaultedSignal(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_WidgetViewSignal_Empty")]
        public static extern bool WidgetViewSignal_Empty(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_WidgetViewSignal_GetConnectionCount")]
        public static extern uint WidgetViewSignal_GetConnectionCount(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_WidgetViewSignal_Connect")]
        public static extern void WidgetViewSignal_Connect(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_WidgetViewSignal_Disconnect")]
        public static extern void WidgetViewSignal_Disconnect(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_WidgetViewSignal_Emit")]
        public static extern void WidgetViewSignal_Emit(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_new_WidgetViewSignal")]
        public static extern global::System.IntPtr new_WidgetViewSignal();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_delete_WidgetViewSignal")]
        public static extern void delete_WidgetViewSignal(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_WidgetView_SWIGUpcast")]
        public static extern global::System.IntPtr WidgetView_SWIGUpcast(global::System.IntPtr jarg1);

        // For widget view manager
        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_WidgetViewManager_New")]
        public static extern global::System.IntPtr WidgetViewManager_New(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_WidgetViewManager_DownCast")]
        public static extern global::System.IntPtr WidgetViewManager_DownCast(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_new_WidgetViewManager__SWIG_0")]
        public static extern global::System.IntPtr new_WidgetViewManager__SWIG_0();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_new_WidgetViewManager__SWIG_1")]
        public static extern global::System.IntPtr new_WidgetViewManager__SWIG_1(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_WidgetViewManager_Assign")]
        public static extern global::System.IntPtr WidgetViewManager_Assign(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_delete_WidgetViewManager")]
        public static extern void delete_WidgetViewManager(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_WidgetViewManager_AddWidget")]
        public static extern global::System.IntPtr WidgetViewManager_AddWidget(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2, string jarg3, int jarg4, int jarg5, float jarg6);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_WidgetViewManager_SWIGUpcast")]
        public static extern global::System.IntPtr WidgetViewManager_SWIGUpcast(global::System.IntPtr jarg1);

        //For Adaptor
        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_Adaptor_New__SWIG_0")]
        public static extern global::System.IntPtr Adaptor_New__SWIG_0(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_Adaptor_New__SWIG_1")]
        public static extern global::System.IntPtr Adaptor_New__SWIG_1(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_Adaptor_New__SWIG_2")]
        public static extern global::System.IntPtr Adaptor_New__SWIG_2(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_Adaptor_New__SWIG_3")]
        public static extern global::System.IntPtr Adaptor_New__SWIG_3(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2, global::System.Runtime.InteropServices.HandleRef jarg3);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_delete_Adaptor")]
        public static extern void delete_Adaptor(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_Adaptor_Start")]
        public static extern void Adaptor_Start(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_Adaptor_Pause")]
        public static extern void Adaptor_Pause(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_Adaptor_Resume")]
        public static extern void Adaptor_Resume(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_Adaptor_Stop")]
        public static extern void Adaptor_Stop(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_Adaptor_AddIdle")]
        public static extern bool Adaptor_AddIdle(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_Adaptor_RemoveIdle")]
        public static extern void Adaptor_RemoveIdle(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_Adaptor_ReplaceSurface")]
        public static extern void Adaptor_ReplaceSurface(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2, global::System.Runtime.InteropServices.HandleRef jarg3);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_Adaptor_GetSurface")]
        public static extern global::System.IntPtr Adaptor_GetSurface(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_Adaptor_GetNativeWindowHandle")]
        public static extern global::System.IntPtr Adaptor_GetNativeWindowHandle(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_Adaptor_ReleaseSurfaceLock")]
        public static extern void Adaptor_ReleaseSurfaceLock(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_Adaptor_SetRenderRefreshRate")]
        public static extern void Adaptor_SetRenderRefreshRate(global::System.Runtime.InteropServices.HandleRef jarg1, uint jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_Adaptor_SetUseHardwareVSync")]
        public static extern void Adaptor_SetUseHardwareVSync(global::System.Runtime.InteropServices.HandleRef jarg1, bool jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_Adaptor_Get")]
        public static extern global::System.IntPtr Adaptor_Get();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_Adaptor_IsAvailable")]
        public static extern bool Adaptor_IsAvailable();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_Adaptor_NotifySceneCreated")]
        public static extern void Adaptor_NotifySceneCreated(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_Adaptor_NotifyLanguageChanged")]
        public static extern void Adaptor_NotifyLanguageChanged(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_Adaptor_SetMinimumPinchDistance")]
        public static extern void Adaptor_SetMinimumPinchDistance(global::System.Runtime.InteropServices.HandleRef jarg1, float jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_Adaptor_FeedTouchPoint")]
        public static extern void Adaptor_FeedTouchPoint(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2, int jarg3);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_Adaptor_FeedWheelEvent")]
        public static extern void Adaptor_FeedWheelEvent(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_Adaptor_FeedKeyEvent")]
        public static extern void Adaptor_FeedKeyEvent(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_Adaptor_SceneCreated")]
        public static extern void Adaptor_SceneCreated(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_Adaptor_SetViewMode")]
        public static extern void Adaptor_SetViewMode(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_Adaptor_SetStereoBase")]
        public static extern void Adaptor_SetStereoBase(global::System.Runtime.InteropServices.HandleRef jarg1, float jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_Adaptor_ResizedSignal")]
        public static extern global::System.IntPtr Adaptor_ResizedSignal(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_Adaptor_LanguageChangedSignal")]
        public static extern global::System.IntPtr Adaptor_LanguageChangedSignal(global::System.Runtime.InteropServices.HandleRef jarg1);

        //Adaptor Signal Type
        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_AdaptorSignalType_Empty")]
        public static extern bool AdaptorSignalType_Empty(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_AdaptorSignalType_GetConnectionCount")]
        public static extern uint AdaptorSignalType_GetConnectionCount(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_AdaptorSignalType_Connect")]
        public static extern void AdaptorSignalType_Connect(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_AdaptorSignalType_Disconnect")]
        public static extern void AdaptorSignalType_Disconnect(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_AdaptorSignalType_Emit")]
        public static extern void AdaptorSignalType_Emit(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_new_AdaptorSignalType")]
        public static extern global::System.IntPtr new_AdaptorSignalType();

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint="CSharp_Dali_delete_AdaptorSignalType")]
        public static extern void delete_AdaptorSignalType(global::System.Runtime.InteropServices.HandleRef jarg1);

        [global::System.Runtime.InteropServices.DllImport("libdali-csharp-binder.so", EntryPoint = "CSharp_Dali_MakeCallback")]
        public static extern global::System.IntPtr MakeCallback(global::System.Runtime.InteropServices.HandleRef jarg1);

    }
}
