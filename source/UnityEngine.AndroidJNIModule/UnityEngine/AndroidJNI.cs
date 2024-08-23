using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x0200000E RID: 14
	[StaticAccessor("AndroidJNIBindingsHelpers", StaticAccessorType.DoubleColon)]
	[NativeHeader("Modules/AndroidJNI/Public/AndroidJNIBindingsHelpers.h")]
	[NativeConditional("PLATFORM_ANDROID")]
	[global::Cpp2ILInjected.Token(Token = "0x200000E")]
	public static class AndroidJNI
	{
		// Token: 0x060000DD RID: 221
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x60000DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F64984", Offset = "0x1F64984", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern int AttachCurrentThread();

		// Token: 0x060000DE RID: 222
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x60000DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F649AC", Offset = "0x1F649AC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern int DetachCurrentThread();

		// Token: 0x060000DF RID: 223
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x60000DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F649D4", Offset = "0x1F649D4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern int GetVersion();

		// Token: 0x060000E0 RID: 224
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x60000E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F575D4", Offset = "0x1F575D4", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "AndroidImmersive", Member = "GetSDKLevel", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern IntPtr FindClass(string name);

		// Token: 0x060000E1 RID: 225
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x60000E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F580E8", Offset = "0x1F580E8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern IntPtr FromReflectedMethod(IntPtr refMethod);

		// Token: 0x060000E2 RID: 226
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x60000E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F649FC", Offset = "0x1F649FC", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern IntPtr FromReflectedField(IntPtr refField);

		// Token: 0x060000E3 RID: 227
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x60000E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F64A38", Offset = "0x1F64A38", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern IntPtr ToReflectedMethod(IntPtr clazz, IntPtr methodID, bool isStatic);

		// Token: 0x060000E4 RID: 228
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x60000E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F64A8C", Offset = "0x1F64A8C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern IntPtr ToReflectedField(IntPtr clazz, IntPtr fieldID, bool isStatic);

		// Token: 0x060000E5 RID: 229
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x60000E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F64AE0", Offset = "0x1F64AE0", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern IntPtr GetSuperclass(IntPtr clazz);

		// Token: 0x060000E6 RID: 230
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x60000E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F64B1C", Offset = "0x1F64B1C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern bool IsAssignableFrom(IntPtr clazz1, IntPtr clazz2);

		// Token: 0x060000E7 RID: 231
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x60000E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F64B60", Offset = "0x1F64B60", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern int Throw(IntPtr obj);

		// Token: 0x060000E8 RID: 232
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x60000E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F64B9C", Offset = "0x1F64B9C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern int ThrowNew(IntPtr clazz, string message);

		// Token: 0x060000E9 RID: 233
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x60000E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F57584", Offset = "0x1F57584", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern IntPtr ExceptionOccurred();

		// Token: 0x060000EA RID: 234
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x60000EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F64BE0", Offset = "0x1F64BE0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void ExceptionDescribe();

		// Token: 0x060000EB RID: 235
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x60000EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F575AC", Offset = "0x1F575AC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void ExceptionClear();

		// Token: 0x060000EC RID: 236
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x60000EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F64C08", Offset = "0x1F64C08", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void FatalError(string message);

		// Token: 0x060000ED RID: 237
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x60000ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F639B8", Offset = "0x1F639B8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern int PushLocalFrame(int capacity);

		// Token: 0x060000EE RID: 238
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x60000EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F64C44", Offset = "0x1F64C44", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern IntPtr PopLocalFrame(IntPtr ptr);

		// Token: 0x060000EF RID: 239
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x60000EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5D51C", Offset = "0x1F5D51C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern IntPtr NewGlobalRef(IntPtr obj);

		// Token: 0x060000F0 RID: 240
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x60000F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F57860", Offset = "0x1F57860", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void DeleteGlobalRef(IntPtr obj);

		// Token: 0x060000F1 RID: 241
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x60000F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5F7F0", Offset = "0x1F5F7F0", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern IntPtr NewWeakGlobalRef(IntPtr obj);

		// Token: 0x060000F2 RID: 242
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x60000F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F57928", Offset = "0x1F57928", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void DeleteWeakGlobalRef(IntPtr obj);

		// Token: 0x060000F3 RID: 243
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x60000F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5F6F8", Offset = "0x1F5F6F8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern IntPtr NewLocalRef(IntPtr obj);

		// Token: 0x060000F4 RID: 244
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x60000F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F579F0", Offset = "0x1F579F0", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void DeleteLocalRef(IntPtr obj);

		// Token: 0x060000F5 RID: 245
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x60000F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5F4E8", Offset = "0x1F5F4E8", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern bool IsSameObject(IntPtr obj1, IntPtr obj2);

		// Token: 0x060000F6 RID: 246
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x60000F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F64C80", Offset = "0x1F64C80", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern int EnsureLocalCapacity(int capacity);

		// Token: 0x060000F7 RID: 247
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x60000F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F64CBC", Offset = "0x1F64CBC", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern IntPtr AllocObject(IntPtr clazz);

		// Token: 0x060000F8 RID: 248
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x60000F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5827C", Offset = "0x1F5827C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern IntPtr NewObject(IntPtr clazz, IntPtr methodID, jvalue[] args);

		// Token: 0x060000F9 RID: 249
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x60000F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F57C84", Offset = "0x1F57C84", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern IntPtr GetObjectClass(IntPtr obj);

		// Token: 0x060000FA RID: 250
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x60000FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F64CF8", Offset = "0x1F64CF8", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern bool IsInstanceOf(IntPtr obj, IntPtr clazz);

		// Token: 0x060000FB RID: 251
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x60000FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F57610", Offset = "0x1F57610", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern IntPtr GetMethodID(IntPtr clazz, string name, string sig);

		// Token: 0x060000FC RID: 252
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x60000FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F57EE8", Offset = "0x1F57EE8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern IntPtr GetFieldID(IntPtr clazz, string name, string sig);

		// Token: 0x060000FD RID: 253
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x60000FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F57664", Offset = "0x1F57664", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig);

		// Token: 0x060000FE RID: 254
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x60000FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F57FF4", Offset = "0x1F57FF4", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "AndroidImmersive", Member = "GetSDKLevel", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig);

		// Token: 0x060000FF RID: 255 RVA: 0x000022D8 File Offset: 0x000004D8
		[global::Cpp2ILInjected.Token(Token = "0x60000FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F57ACC", Offset = "0x1F57ACC", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static IntPtr NewString(string chars)
		{
			throw null;
		}

		// Token: 0x06000100 RID: 256
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000100")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F64D3C", Offset = "0x1F64D3C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern IntPtr NewStringFromStr(string chars);

		// Token: 0x06000101 RID: 257
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000101")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F64D78", Offset = "0x1F64D78", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern IntPtr NewString(char[] chars);

		// Token: 0x06000102 RID: 258
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000102")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F64DB4", Offset = "0x1F64DB4", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern IntPtr NewStringUTF(string bytes);

		// Token: 0x06000103 RID: 259
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000103")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F57BA8", Offset = "0x1F57BA8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern string GetStringChars(IntPtr str);

		// Token: 0x06000104 RID: 260
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000104")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F64DF0", Offset = "0x1F64DF0", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern int GetStringLength(IntPtr str);

		// Token: 0x06000105 RID: 261
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000105")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F64E2C", Offset = "0x1F64E2C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern int GetStringUTFLength(IntPtr str);

		// Token: 0x06000106 RID: 262
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000106")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F64E68", Offset = "0x1F64E68", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern string GetStringUTFChars(IntPtr str);

		// Token: 0x06000107 RID: 263
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000107")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F576B8", Offset = "0x1F576B8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args);

		// Token: 0x06000108 RID: 264
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000108")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5B7C4", Offset = "0x1F5B7C4", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args);

		// Token: 0x06000109 RID: 265
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000109")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5C0F4", Offset = "0x1F5C0F4", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern int CallIntMethod(IntPtr obj, IntPtr methodID, jvalue[] args);

		// Token: 0x0600010A RID: 266
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600010A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5BFE8", Offset = "0x1F5BFE8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern bool CallBooleanMethod(IntPtr obj, IntPtr methodID, jvalue[] args);

		// Token: 0x0600010B RID: 267
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600010B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5BDD0", Offset = "0x1F5BDD0", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern short CallShortMethod(IntPtr obj, IntPtr methodID, jvalue[] args);

		// Token: 0x0600010C RID: 268 RVA: 0x000022DB File Offset: 0x000004DB
		[Obsolete("AndroidJNI.CallByteMethod is obsolete. Use AndroidJNI.CallSByteMethod method instead")]
		[global::Cpp2ILInjected.Token(Token = "0x600010C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F64EA4", Offset = "0x1F64EA4", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static byte CallByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			throw null;
		}

		// Token: 0x0600010D RID: 269
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600010D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5BEDC", Offset = "0x1F5BEDC", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args);

		// Token: 0x0600010E RID: 270
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600010E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5B988", Offset = "0x1F5B988", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern char CallCharMethod(IntPtr obj, IntPtr methodID, jvalue[] args);

		// Token: 0x0600010F RID: 271
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600010F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5BBB8", Offset = "0x1F5BBB8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern float CallFloatMethod(IntPtr obj, IntPtr methodID, jvalue[] args);

		// Token: 0x06000110 RID: 272
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000110")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5BAA0", Offset = "0x1F5BAA0", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern double CallDoubleMethod(IntPtr obj, IntPtr methodID, jvalue[] args);

		// Token: 0x06000111 RID: 273
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000111")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5BCC4", Offset = "0x1F5BCC4", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern long CallLongMethod(IntPtr obj, IntPtr methodID, jvalue[] args);

		// Token: 0x06000112 RID: 274
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000112")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5B6B8", Offset = "0x1F5B6B8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void CallVoidMethod(IntPtr obj, IntPtr methodID, jvalue[] args);

		// Token: 0x06000113 RID: 275
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000113")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5AE40", Offset = "0x1F5AE40", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern string GetStringField(IntPtr obj, IntPtr fieldID);

		// Token: 0x06000114 RID: 276
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000114")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5AD54", Offset = "0x1F5AD54", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern IntPtr GetObjectField(IntPtr obj, IntPtr fieldID);

		// Token: 0x06000115 RID: 277
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000115")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5B4CC", Offset = "0x1F5B4CC", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern bool GetBooleanField(IntPtr obj, IntPtr fieldID);

		// Token: 0x06000116 RID: 278 RVA: 0x000022DE File Offset: 0x000004DE
		[Obsolete("AndroidJNI.GetByteField is obsolete. Use AndroidJNI.GetSByteField method instead")]
		[global::Cpp2ILInjected.Token(Token = "0x6000116")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F64EF8", Offset = "0x1F64EF8", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static byte GetByteField(IntPtr obj, IntPtr fieldID)
		{
			throw null;
		}

		// Token: 0x06000117 RID: 279
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000117")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5B3E0", Offset = "0x1F5B3E0", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern sbyte GetSByteField(IntPtr obj, IntPtr fieldID);

		// Token: 0x06000118 RID: 280
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000118")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5AF2C", Offset = "0x1F5AF2C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern char GetCharField(IntPtr obj, IntPtr fieldID);

		// Token: 0x06000119 RID: 281
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000119")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5B2F4", Offset = "0x1F5B2F4", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern short GetShortField(IntPtr obj, IntPtr fieldID);

		// Token: 0x0600011A RID: 282
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600011A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5B5B8", Offset = "0x1F5B5B8", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern int GetIntField(IntPtr obj, IntPtr fieldID);

		// Token: 0x0600011B RID: 283
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600011B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5B208", Offset = "0x1F5B208", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern long GetLongField(IntPtr obj, IntPtr fieldID);

		// Token: 0x0600011C RID: 284
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600011C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5B11C", Offset = "0x1F5B11C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern float GetFloatField(IntPtr obj, IntPtr fieldID);

		// Token: 0x0600011D RID: 285
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600011D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5B024", Offset = "0x1F5B024", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern double GetDoubleField(IntPtr obj, IntPtr fieldID);

		// Token: 0x0600011E RID: 286
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600011E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5A3D8", Offset = "0x1F5A3D8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void SetStringField(IntPtr obj, IntPtr fieldID, string val);

		// Token: 0x0600011F RID: 287
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600011F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5A2C8", Offset = "0x1F5A2C8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void SetObjectField(IntPtr obj, IntPtr fieldID, IntPtr val);

		// Token: 0x06000120 RID: 288
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000120")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5AB48", Offset = "0x1F5AB48", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void SetBooleanField(IntPtr obj, IntPtr fieldID, bool val);

		// Token: 0x06000121 RID: 289 RVA: 0x000022E1 File Offset: 0x000004E1
		[Obsolete("AndroidJNI.SetByteField is obsolete. Use AndroidJNI.SetSByteField method instead")]
		[global::Cpp2ILInjected.Token(Token = "0x6000121")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F64F3C", Offset = "0x1F64F3C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void SetByteField(IntPtr obj, IntPtr fieldID, byte val)
		{
			throw null;
		}

		// Token: 0x06000122 RID: 290
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000122")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5AA38", Offset = "0x1F5AA38", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void SetSByteField(IntPtr obj, IntPtr fieldID, sbyte val);

		// Token: 0x06000123 RID: 291
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000123")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5A4E8", Offset = "0x1F5A4E8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void SetCharField(IntPtr obj, IntPtr fieldID, char val);

		// Token: 0x06000124 RID: 292
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000124")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5A928", Offset = "0x1F5A928", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void SetShortField(IntPtr obj, IntPtr fieldID, short val);

		// Token: 0x06000125 RID: 293
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000125")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5AC58", Offset = "0x1F5AC58", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void SetIntField(IntPtr obj, IntPtr fieldID, int val);

		// Token: 0x06000126 RID: 294
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000126")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5A818", Offset = "0x1F5A818", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void SetLongField(IntPtr obj, IntPtr fieldID, long val);

		// Token: 0x06000127 RID: 295
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000127")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5A708", Offset = "0x1F5A708", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void SetFloatField(IntPtr obj, IntPtr fieldID, float val);

		// Token: 0x06000128 RID: 296
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000128")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5A5F8", Offset = "0x1F5A5F8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void SetDoubleField(IntPtr obj, IntPtr fieldID, double val);

		// Token: 0x06000129 RID: 297
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000129")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5770C", Offset = "0x1F5770C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args);

		// Token: 0x0600012A RID: 298
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600012A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F59888", Offset = "0x1F59888", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args);

		// Token: 0x0600012B RID: 299
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600012B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5A1B8", Offset = "0x1F5A1B8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, jvalue[] args);

		// Token: 0x0600012C RID: 300
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600012C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5A0AC", Offset = "0x1F5A0AC", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, jvalue[] args);

		// Token: 0x0600012D RID: 301
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600012D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F59E94", Offset = "0x1F59E94", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, jvalue[] args);

		// Token: 0x0600012E RID: 302 RVA: 0x000022E4 File Offset: 0x000004E4
		[Obsolete("AndroidJNI.CallStaticByteMethod is obsolete. Use AndroidJNI.CallStaticSByteMethod method instead")]
		[global::Cpp2ILInjected.Token(Token = "0x600012E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F64F90", Offset = "0x1F64F90", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static byte CallStaticByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			throw null;
		}

		// Token: 0x0600012F RID: 303
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600012F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F59FA0", Offset = "0x1F59FA0", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args);

		// Token: 0x06000130 RID: 304
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000130")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F59A4C", Offset = "0x1F59A4C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, jvalue[] args);

		// Token: 0x06000131 RID: 305
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000131")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F59C7C", Offset = "0x1F59C7C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, jvalue[] args);

		// Token: 0x06000132 RID: 306
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000132")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F59B64", Offset = "0x1F59B64", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, jvalue[] args);

		// Token: 0x06000133 RID: 307
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000133")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F59D88", Offset = "0x1F59D88", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, jvalue[] args);

		// Token: 0x06000134 RID: 308
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000134")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5977C", Offset = "0x1F5977C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, jvalue[] args);

		// Token: 0x06000135 RID: 309
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000135")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F58F04", Offset = "0x1F58F04", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern string GetStaticStringField(IntPtr clazz, IntPtr fieldID);

		// Token: 0x06000136 RID: 310
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000136")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F58E18", Offset = "0x1F58E18", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID);

		// Token: 0x06000137 RID: 311
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000137")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F59590", Offset = "0x1F59590", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID);

		// Token: 0x06000138 RID: 312 RVA: 0x000022E7 File Offset: 0x000004E7
		[Obsolete("AndroidJNI.GetStaticByteField is obsolete. Use AndroidJNI.GetStaticSByteField method instead")]
		[global::Cpp2ILInjected.Token(Token = "0x6000138")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F64FE4", Offset = "0x1F64FE4", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static byte GetStaticByteField(IntPtr clazz, IntPtr fieldID)
		{
			throw null;
		}

		// Token: 0x06000139 RID: 313
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000139")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F594A4", Offset = "0x1F594A4", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern sbyte GetStaticSByteField(IntPtr clazz, IntPtr fieldID);

		// Token: 0x0600013A RID: 314
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600013A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F58FF0", Offset = "0x1F58FF0", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern char GetStaticCharField(IntPtr clazz, IntPtr fieldID);

		// Token: 0x0600013B RID: 315
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600013B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F593B8", Offset = "0x1F593B8", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern short GetStaticShortField(IntPtr clazz, IntPtr fieldID);

		// Token: 0x0600013C RID: 316
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600013C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5967C", Offset = "0x1F5967C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "AndroidImmersive", Member = "GetSDKLevel", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern int GetStaticIntField(IntPtr clazz, IntPtr fieldID);

		// Token: 0x0600013D RID: 317
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600013D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F592CC", Offset = "0x1F592CC", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern long GetStaticLongField(IntPtr clazz, IntPtr fieldID);

		// Token: 0x0600013E RID: 318
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600013E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F591E0", Offset = "0x1F591E0", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern float GetStaticFloatField(IntPtr clazz, IntPtr fieldID);

		// Token: 0x0600013F RID: 319
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600013F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F590E8", Offset = "0x1F590E8", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID);

		// Token: 0x06000140 RID: 320
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000140")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5849C", Offset = "0x1F5849C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void SetStaticStringField(IntPtr clazz, IntPtr fieldID, string val);

		// Token: 0x06000141 RID: 321
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000141")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5838C", Offset = "0x1F5838C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void SetStaticObjectField(IntPtr clazz, IntPtr fieldID, IntPtr val);

		// Token: 0x06000142 RID: 322
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000142")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F58C0C", Offset = "0x1F58C0C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void SetStaticBooleanField(IntPtr clazz, IntPtr fieldID, bool val);

		// Token: 0x06000143 RID: 323 RVA: 0x000022EA File Offset: 0x000004EA
		[Obsolete("AndroidJNI.SetStaticByteField is obsolete. Use AndroidJNI.SetStaticSByteField method instead")]
		[global::Cpp2ILInjected.Token(Token = "0x6000143")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F65028", Offset = "0x1F65028", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void SetStaticByteField(IntPtr clazz, IntPtr fieldID, byte val)
		{
			throw null;
		}

		// Token: 0x06000144 RID: 324
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000144")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F58AFC", Offset = "0x1F58AFC", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void SetStaticSByteField(IntPtr clazz, IntPtr fieldID, sbyte val);

		// Token: 0x06000145 RID: 325
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000145")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F585AC", Offset = "0x1F585AC", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void SetStaticCharField(IntPtr clazz, IntPtr fieldID, char val);

		// Token: 0x06000146 RID: 326
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000146")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F589EC", Offset = "0x1F589EC", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void SetStaticShortField(IntPtr clazz, IntPtr fieldID, short val);

		// Token: 0x06000147 RID: 327
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000147")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F58D1C", Offset = "0x1F58D1C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void SetStaticIntField(IntPtr clazz, IntPtr fieldID, int val);

		// Token: 0x06000148 RID: 328
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000148")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F588DC", Offset = "0x1F588DC", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void SetStaticLongField(IntPtr clazz, IntPtr fieldID, long val);

		// Token: 0x06000149 RID: 329
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000149")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F587CC", Offset = "0x1F587CC", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void SetStaticFloatField(IntPtr clazz, IntPtr fieldID, float val);

		// Token: 0x0600014A RID: 330
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600014A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F586BC", Offset = "0x1F586BC", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void SetStaticDoubleField(IntPtr clazz, IntPtr fieldID, double val);

		// Token: 0x0600014B RID: 331
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600014B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5D094", Offset = "0x1F5D094", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern IntPtr ToBooleanArray(bool[] array);

		// Token: 0x0600014C RID: 332
		[ThreadSafe]
		[Obsolete("AndroidJNI.ToByteArray is obsolete. Use AndroidJNI.ToSByteArray method instead")]
		[global::Cpp2ILInjected.Token(Token = "0x600014C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5CEDC", Offset = "0x1F5CEDC", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern IntPtr ToByteArray(byte[] array);

		// Token: 0x0600014D RID: 333
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600014D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5CFB8", Offset = "0x1F5CFB8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern IntPtr ToSByteArray(sbyte[] array);

		// Token: 0x0600014E RID: 334
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600014E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5CA90", Offset = "0x1F5CA90", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern IntPtr ToCharArray(char[] array);

		// Token: 0x0600014F RID: 335
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600014F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5CE00", Offset = "0x1F5CE00", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern IntPtr ToShortArray(short[] array);

		// Token: 0x06000150 RID: 336
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000150")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5D170", Offset = "0x1F5D170", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern IntPtr ToIntArray(int[] array);

		// Token: 0x06000151 RID: 337
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000151")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5CD24", Offset = "0x1F5CD24", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern IntPtr ToLongArray(long[] array);

		// Token: 0x06000152 RID: 338
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000152")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5CC48", Offset = "0x1F5CC48", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern IntPtr ToFloatArray(float[] array);

		// Token: 0x06000153 RID: 339
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000153")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5CB6C", Offset = "0x1F5CB6C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern IntPtr ToDoubleArray(double[] array);

		// Token: 0x06000154 RID: 340
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000154")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5C9AC", Offset = "0x1F5C9AC", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern IntPtr ToObjectArray(IntPtr[] array, IntPtr arrayClass);

		// Token: 0x06000155 RID: 341 RVA: 0x000022ED File Offset: 0x000004ED
		[global::Cpp2ILInjected.Token(Token = "0x6000155")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6507C", Offset = "0x1F6507C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static IntPtr ToObjectArray(IntPtr[] array)
		{
			throw null;
		}

		// Token: 0x06000156 RID: 342
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000156")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5C7EC", Offset = "0x1F5C7EC", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern bool[] FromBooleanArray(IntPtr array);

		// Token: 0x06000157 RID: 343
		[ThreadSafe]
		[Obsolete("AndroidJNI.FromByteArray is obsolete. Use AndroidJNI.FromSByteArray method instead")]
		[global::Cpp2ILInjected.Token(Token = "0x6000157")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5C634", Offset = "0x1F5C634", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern byte[] FromByteArray(IntPtr array);

		// Token: 0x06000158 RID: 344
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000158")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5C710", Offset = "0x1F5C710", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern sbyte[] FromSByteArray(IntPtr array);

		// Token: 0x06000159 RID: 345
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000159")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5C1E8", Offset = "0x1F5C1E8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern char[] FromCharArray(IntPtr array);

		// Token: 0x0600015A RID: 346
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600015A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5C558", Offset = "0x1F5C558", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern short[] FromShortArray(IntPtr array);

		// Token: 0x0600015B RID: 347
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600015B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5C8C8", Offset = "0x1F5C8C8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern int[] FromIntArray(IntPtr array);

		// Token: 0x0600015C RID: 348
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600015C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5C47C", Offset = "0x1F5C47C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern long[] FromLongArray(IntPtr array);

		// Token: 0x0600015D RID: 349
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600015D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5C3A0", Offset = "0x1F5C3A0", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern float[] FromFloatArray(IntPtr array);

		// Token: 0x0600015E RID: 350
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600015E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5C2C4", Offset = "0x1F5C2C4", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern double[] FromDoubleArray(IntPtr array);

		// Token: 0x0600015F RID: 351
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600015F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F650F0", Offset = "0x1F650F0", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern IntPtr[] FromObjectArray(IntPtr array);

		// Token: 0x06000160 RID: 352
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000160")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5D338", Offset = "0x1F5D338", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern int GetArrayLength(IntPtr array);

		// Token: 0x06000161 RID: 353
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000161")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6512C", Offset = "0x1F6512C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern IntPtr NewBooleanArray(int size);

		// Token: 0x06000162 RID: 354 RVA: 0x000022F0 File Offset: 0x000004F0
		[Obsolete("AndroidJNI.NewByteArray is obsolete. Use AndroidJNI.NewSByteArray method instead")]
		[global::Cpp2ILInjected.Token(Token = "0x6000162")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F65168", Offset = "0x1F65168", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static IntPtr NewByteArray(int size)
		{
			throw null;
		}

		// Token: 0x06000163 RID: 355
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000163")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F651A4", Offset = "0x1F651A4", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern IntPtr NewSByteArray(int size);

		// Token: 0x06000164 RID: 356
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000164")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F651E0", Offset = "0x1F651E0", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern IntPtr NewCharArray(int size);

		// Token: 0x06000165 RID: 357
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000165")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6521C", Offset = "0x1F6521C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern IntPtr NewShortArray(int size);

		// Token: 0x06000166 RID: 358
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000166")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F65258", Offset = "0x1F65258", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern IntPtr NewIntArray(int size);

		// Token: 0x06000167 RID: 359
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000167")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F65294", Offset = "0x1F65294", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern IntPtr NewLongArray(int size);

		// Token: 0x06000168 RID: 360
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000168")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F652D0", Offset = "0x1F652D0", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern IntPtr NewFloatArray(int size);

		// Token: 0x06000169 RID: 361
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000169")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6530C", Offset = "0x1F6530C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern IntPtr NewDoubleArray(int size);

		// Token: 0x0600016A RID: 362
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600016A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F62FC4", Offset = "0x1F62FC4", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern IntPtr NewObjectArray(int size, IntPtr clazz, IntPtr obj);

		// Token: 0x0600016B RID: 363
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600016B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F65348", Offset = "0x1F65348", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "KeyboardInput", Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 30)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern bool GetBooleanArrayElement(IntPtr array, int index);

		// Token: 0x0600016C RID: 364 RVA: 0x000022F3 File Offset: 0x000004F3
		[Obsolete("AndroidJNI.GetByteArrayElement is obsolete. Use AndroidJNI.GetSByteArrayElement method instead")]
		[global::Cpp2ILInjected.Token(Token = "0x600016C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6538C", Offset = "0x1F6538C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static byte GetByteArrayElement(IntPtr array, int index)
		{
			throw null;
		}

		// Token: 0x0600016D RID: 365
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600016D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F653D0", Offset = "0x1F653D0", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern sbyte GetSByteArrayElement(IntPtr array, int index);

		// Token: 0x0600016E RID: 366
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600016E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F65414", Offset = "0x1F65414", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern char GetCharArrayElement(IntPtr array, int index);

		// Token: 0x0600016F RID: 367
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600016F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F65458", Offset = "0x1F65458", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern short GetShortArrayElement(IntPtr array, int index);

		// Token: 0x06000170 RID: 368
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000170")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6549C", Offset = "0x1F6549C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern int GetIntArrayElement(IntPtr array, int index);

		// Token: 0x06000171 RID: 369
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000171")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F654E0", Offset = "0x1F654E0", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern long GetLongArrayElement(IntPtr array, int index);

		// Token: 0x06000172 RID: 370
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000172")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F65524", Offset = "0x1F65524", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern float GetFloatArrayElement(IntPtr array, int index);

		// Token: 0x06000173 RID: 371
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000173")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F65568", Offset = "0x1F65568", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern double GetDoubleArrayElement(IntPtr array, int index);

		// Token: 0x06000174 RID: 372
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000174")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5D254", Offset = "0x1F5D254", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertFromJNIArray", MemberTypeParameters = new object[] { "ArrayType" }, MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = "ArrayType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern IntPtr GetObjectArrayElement(IntPtr array, int index);

		// Token: 0x06000175 RID: 373 RVA: 0x000022F6 File Offset: 0x000004F6
		[Obsolete("AndroidJNI.SetBooleanArrayElement(IntPtr, int, byte) is obsolete. Use AndroidJNI.SetBooleanArrayElement(IntPtr, int, bool) method instead")]
		[global::Cpp2ILInjected.Token(Token = "0x6000175")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F655AC", Offset = "0x1F655AC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void SetBooleanArrayElement(IntPtr array, int index, byte val)
		{
			throw null;
		}

		// Token: 0x06000176 RID: 374
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000176")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F65604", Offset = "0x1F65604", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void SetBooleanArrayElement(IntPtr array, int index, bool val);

		// Token: 0x06000177 RID: 375 RVA: 0x000022F9 File Offset: 0x000004F9
		[Obsolete("AndroidJNI.SetByteArrayElement is obsolete. Use AndroidJNI.SetSByteArrayElement method instead")]
		[global::Cpp2ILInjected.Token(Token = "0x6000177")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F65658", Offset = "0x1F65658", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void SetByteArrayElement(IntPtr array, int index, sbyte val)
		{
			throw null;
		}

		// Token: 0x06000178 RID: 376
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000178")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F656AC", Offset = "0x1F656AC", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void SetSByteArrayElement(IntPtr array, int index, sbyte val);

		// Token: 0x06000179 RID: 377
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000179")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F65700", Offset = "0x1F65700", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void SetCharArrayElement(IntPtr array, int index, char val);

		// Token: 0x0600017A RID: 378
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600017A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F65754", Offset = "0x1F65754", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void SetShortArrayElement(IntPtr array, int index, short val);

		// Token: 0x0600017B RID: 379
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600017B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F657A8", Offset = "0x1F657A8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void SetIntArrayElement(IntPtr array, int index, int val);

		// Token: 0x0600017C RID: 380
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600017C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F657FC", Offset = "0x1F657FC", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void SetLongArrayElement(IntPtr array, int index, long val);

		// Token: 0x0600017D RID: 381
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600017D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F65850", Offset = "0x1F65850", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void SetFloatArrayElement(IntPtr array, int index, float val);

		// Token: 0x0600017E RID: 382
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600017E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F658A4", Offset = "0x1F658A4", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void SetDoubleArrayElement(IntPtr array, int index, double val);

		// Token: 0x0600017F RID: 383
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x600017F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F63018", Offset = "0x1F63018", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void SetObjectArrayElement(IntPtr array, int index, IntPtr obj);
	}
}
