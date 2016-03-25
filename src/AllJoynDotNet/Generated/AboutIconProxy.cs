// Generated from AboutIconProxy.h

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;

namespace AllJoynDotNet
{
//
    public partial class AboutIconProxy : AllJoynWrapper
    {
        internal AboutIconProxy(IntPtr handle) : base(handle) { }
		/// <summary>
		/// Allocate a new alljoyn_abouticonproxy object.
		/// </summary>
		/// <param name="bus">reference to bus attachment object</param>
		/// <param name="busName">Unique or well-known name of an AllJoyn bus you have joined</param>
		/// <param name="sessionId">the session received after joining an AllJoyn session</param>
		/// <returns>The allocated alljoyn_abouticonproxy.</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern IntPtr alljoyn_abouticonproxy_create(IntPtr bus, [MarshalAs(UnmanagedType.LPStr)]string busName, IntPtr sessionId);
		// extern AJ_API alljoyn_abouticonproxy AJ_CALL alljoyn_abouticonproxy_create(alljoyn_busattachment bus,const char* busName,alljoyn_sessionid sessionId);

		/// <summary>
		/// Free an alljoyn_abouticonproxy object.
		/// </summary>
		/// <param name="proxy">The alljoyn_abouticonproxy to be freed.</param>
		/// 
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern IntPtr alljoyn_abouticonproxy_destroy(IntPtr proxy);
		// extern AJ_API void AJ_CALL alljoyn_abouticonproxy_destroy(alljoyn_abouticonproxy proxy);

		/// <summary>
		/// This method makes multiple proxy bus object method calls to fill in the
		/// content of the alljoyn_abouticon. Its possible for any of the method calls
		/// to fail causing this member function to return an error status.
		/// </summary>
		/// <param name="proxy">alljoyn_abouticonproxy object</param>
		/// <param name="icon">alljoyn_abouticon that holds icon content</param><!-- out -->
		/// <returns>- #ER_OK if successful
		/// - an error status indicating failure to get the icon content</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern QStatus alljoyn_abouticonproxy_geticon(IntPtr proxy, IntPtr icon);
		// extern AJ_API QStatus AJ_CALL alljoyn_abouticonproxy_geticon(alljoyn_abouticonproxy proxy,alljoyn_abouticon icon);

		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern QStatus alljoyn_abouticonproxy_getversion(IntPtr proxy, UInt16[] version);
		// extern AJ_API QStatus AJ_CALL alljoyn_abouticonproxy_getversion(alljoyn_abouticonproxy proxy,uint16_t* version);


    }
}