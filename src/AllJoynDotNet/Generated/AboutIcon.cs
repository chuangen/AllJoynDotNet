// Generated from AboutIcon.h

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
    public partial class AboutIcon : AllJoynWrapper
    {
        internal AboutIcon(IntPtr handle) : base(handle) { }
		/// <summary>
		/// Allocate a new empty alljoyn_abouticon object.
		/// </summary>
		/// <returns>The allocated alljoyn_abouticon.</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern IntPtr alljoyn_abouticon_create();
		// extern AJ_API alljoyn_abouticon AJ_CALL alljoyn_abouticon_create();

		/// <summary>
		/// Free an alljoyn_abouticon object.
		/// </summary>
		/// <param name="icon">the alljoyn_abouticon to be freed.</param>
		/// 
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern IntPtr alljoyn_abouticon_destroy(IntPtr icon);
		// extern AJ_API void AJ_CALL alljoyn_abouticon_destroy(alljoyn_abouticon icon);

		/// <summary>
		/// Returns a pointer to the icon's internal content data as well as the size of this data.
		/// </summary>
		/// <param name="icon">the alljoyn_abouticon object this call is made for</param>
		/// <param name="data">pointer to the icon content data</param><!-- out -->
		/// <param name="size">size (in number of bytes) of the icon content data</param><!-- out -->
		/// 
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern IntPtr alljoyn_abouticon_getcontent(IntPtr icon, byte[] data, UInt64 size);
		// extern AJ_API void AJ_CALL alljoyn_abouticon_getcontent(alljoyn_abouticon icon,const uint8_t** data,size_t* size);

		/// <summary>
		/// Set the content for an icon.  The content must fit into a alljoyn_msgarg so the
		/// largest size for the icon data is ALLJOYN_MAX_ARRAY_LEN bytes.
		/// </summary>
		/// <remarks>
		/// <para>Note as long as the Media Type matches it is possible to set both icon content
		/// and icon URL
		/// </para>
		/// <para>If an error is returned the icon content will remain unchanged.
		/// </para>
		/// </remarks>
		/// <param name="icon">the alljoyn_abouticon object this call is made for</param>
		/// <param name="type">a Media Type indicating the icon image type. Typicalvalue will be `image/jpeg` or `image/png`</param>
		/// <param name="data">pointer to an array of bytes that represent an icon</param>
		/// <param name="csize">the number of bytes in data</param>
		/// <param name="ownsData">if true the alljoyn_abouticon contain gains ownership of thedata that data points to.  The alljoyn_abouticon object will
		/// be responsible for freeing the memory. If false user is
		/// is responsible for freeing memory pointed to by data.</param>
		/// <returns>- ER_OK on success
		/// - ER_BUS_BAD_VALUE if the data is to large to be marshaled
		/// - other status indicating failure</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern QStatus alljoyn_abouticon_setcontent(IntPtr icon, [MarshalAs(UnmanagedType.LPStr)]string type, byte[] data, UInt64 csize, bool ownsData);
		// extern AJ_API QStatus AJ_CALL alljoyn_abouticon_setcontent(alljoyn_abouticon icon,const char* type,uint8_t* data,size_t csize,bool ownsData);

		/// <summary>
		/// Gets the URL that contains the icon for the application.
		/// </summary>
		/// <param name="icon">the alljoyn_abouticon object this call is made for</param>
		/// <param name="type">the Media Type indicating the icon image type</param><!-- out -->
		/// <param name="url">the URL that contains the location of the icon</param><!-- out -->
		/// 
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern IntPtr alljoyn_abouticon_geturl(IntPtr icon, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr)] out string[] type, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr)] out string[] url);
		// extern AJ_API void AJ_CALL alljoyn_abouticon_geturl(alljoyn_abouticon icon,const char** type,const char** url);

		/// <summary>
		/// Set a url that contain the icon for the application.
		/// </summary>
		/// <remarks>
		/// <para>Note as long as the Media Type matches it is possible to set both icon content
		/// and icon URL
		/// </para>
		/// </remarks>
		/// <param name="icon">the alljoyn_abouticon object this call is made for</param>
		/// <param name="type">a Media Type indicating the icon image type. Typicalvalue will be `image/jpeg` or `image/png`</param>
		/// <param name="url">a URL that contain the location of the icon hosted inthe cloud.</param>
		/// <returns>- #ER_OK on success
		/// - other status indicating failure</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern QStatus alljoyn_abouticon_seturl(IntPtr icon, [MarshalAs(UnmanagedType.LPStr)]string type, [MarshalAs(UnmanagedType.LPStr)]string url);
		// extern AJ_API QStatus AJ_CALL alljoyn_abouticon_seturl(alljoyn_abouticon icon,const char* type,const char* url);

		/// <summary>
		/// Clear the alljoyn_abouticon. This will change all strings to empty strings
		/// set the content to NULL and the contentSize to zero.
		/// </summary>
		/// <param name="icon">the alljoyn_abouticon object this call is made for</param>
		/// 
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern IntPtr alljoyn_abouticon_clear(IntPtr icon);
		// extern AJ_API void AJ_CALL alljoyn_abouticon_clear(alljoyn_abouticon icon);

		/// <summary>
		/// Add the IconContent from an alljoyn_msgarg. This will make a local copy of the
		/// alljoyn_msgarg passed in and expose the contents as the member variables content
		/// and contentSize.
		/// </summary>
		/// <param name="icon">the alljoyn_abouticon object this call is made for</param>
		/// <param name="arg">the alljoyn_msgarg containing the Icon</param>
		/// <returns>- ER_OK on success
		/// - status indicating failure otherwise</returns>
		[DllImport(Constants.DLL_IMPORT_TARGET)]
		internal static extern QStatus alljoyn_abouticon_setcontent_frommsgarg(IntPtr icon, IntPtr arg);
		// extern AJ_API QStatus AJ_CALL alljoyn_abouticon_setcontent_frommsgarg(alljoyn_abouticon icon,const alljoyn_msgarg arg);


    }
}