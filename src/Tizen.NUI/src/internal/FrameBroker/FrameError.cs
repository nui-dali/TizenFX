﻿/*
 * Copyright (c) 2020 Samsung Electronics Co., Ltd All Rights Reserved
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
 */

using System.ComponentModel;

namespace Tizen.NUI
{
    /// <summary>
    /// Enumeration for the frame error.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public enum FrameError
    {
        /// <summary>
        /// Succsssful.
        /// </summary>
        None = Interop.FrameBroker.FrameContextErrorCode.None,

        /// <summary>
        /// Disqualified.
        /// </summary>
        /// <remarks>After this error is occured, the FrameBroker instance has to be destroyed.</remarks>
        Disqualified = Interop.FrameBroker.FrameContextErrorCode.Disqualified,

        /// <summary>
        /// Wrong Request.
        /// </summary>
        WrongRequest = Interop.FrameBroker.FrameContextErrorCode.WrongRequest,
    }
}
