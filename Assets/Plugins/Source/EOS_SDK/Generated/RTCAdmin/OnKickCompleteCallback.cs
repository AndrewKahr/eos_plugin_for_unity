// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.RTCAdmin
{
	/// <summary>
	/// Function prototype definition for callbacks passed to <see cref="RTCAdminInterface.Kick" />
	/// </summary>
	/// <param name="data">An <see cref="KickCompleteCallbackInfo" /> containing the output information and result</param>
	public delegate void OnKickCompleteCallback(KickCompleteCallbackInfo data);

	[System.Runtime.InteropServices.UnmanagedFunctionPointer(Config.LibraryCallingConvention)]
	internal delegate void OnKickCompleteCallbackInternal(System.IntPtr data);
}