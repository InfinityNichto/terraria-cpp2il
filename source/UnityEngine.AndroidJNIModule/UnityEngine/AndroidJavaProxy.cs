﻿using System;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Android;

namespace UnityEngine
{
	[global::Cpp2ILInjected.Token(Token = "0x2000007")]
	public class AndroidJavaProxy
	{
		[global::Cpp2ILInjected.Token(Token = "0x600006C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5D6F0", Offset = "0x1F5D6F0", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "AndroidImmersive.Listener", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaRunnableProxy), Member = ".ctor", MemberParameters = new object[] { typeof(AndroidJavaRunnable) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Android.AndroidAssetPacks.AssetPackManagerDownloadStatusCallback", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Action<AndroidAssetPackInfo>),
			typeof(string[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Android.AndroidAssetPacks.AssetPackManagerMobileDataConfirmationCallback", Member = ".ctor", MemberParameters = new object[] { typeof(Action<AndroidAssetPackUseMobileDataRequestResult>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Android.AndroidAssetPacks.AssetPackManagerStatusQueryCallback", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Action<ulong, AndroidAssetPackState[]>),
			typeof(string[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PermissionCallbacks), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaClass), Member = "_AndroidJavaClass", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaProxy), Member = ".ctor", MemberParameters = new object[] { typeof(AndroidJavaClass) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public AndroidJavaProxy(string javaInterface)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600006D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5D7A4", Offset = "0x1F5D7A4", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaProxy), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public AndroidJavaProxy(AndroidJavaClass javaInterface)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600006E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5D810", Offset = "0x1F5D810", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "DeleteWeakGlobalRef", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600006F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5D8A8", Offset = "0x1F5D8A8", Length = "0x5F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new object[]
		{
			typeof(string),
			typeof(BindingFlags),
			typeof(Binder),
			typeof(Type[]),
			typeof(ParameterModifier[])
		}, ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(_AndroidJNIHelper), Member = "Box", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(AndroidJavaObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaProxy), Member = "GetRawProxy", ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Join", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidReflection), Member = "SetNativeExceptionOnProxy", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(Exception),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TargetInvocationException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 59)]
		public virtual AndroidJavaObject Invoke(string methodName, object[] args)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000070")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5E94C", Offset = "0x1F5E94C", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(_AndroidJNIHelper), Member = "Unbox", MemberParameters = new object[] { typeof(AndroidJavaObject) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaObject), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public virtual AndroidJavaObject Invoke(string methodName, AndroidJavaObject[] javaArgs)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000071")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5F3D4", Offset = "0x1F5F3D4", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual bool equals(AndroidJavaObject obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000072")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5F52C", Offset = "0x1F5F52C", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaProxy), Member = "GetRawProxy", ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CallStaticIntMethod", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(IntPtr),
			typeof(jvalue[])
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual int hashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000073")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5F5C8", Offset = "0x1F5F5C8", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual string toString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000074")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5F62C", Offset = "0x1F5F62C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaProxy), Member = "GetRawProxy", ReturnType = typeof(IntPtr))]
		internal AndroidJavaObject GetProxyObject()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000075")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5E72C", Offset = "0x1F5E72C", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaProxy), Member = "Invoke", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(AndroidJavaObject))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaProxy), Member = "hashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaProxy), Member = "GetProxyObject", ReturnType = typeof(AndroidJavaObject))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "InvokeJavaProxyMethod", MemberParameters = new object[]
		{
			typeof(AndroidJavaProxy),
			typeof(IntPtr),
			typeof(IntPtr)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "CreateJNIArgArray", MemberParameters = new object[] { typeof(object[]) }, ReturnType = typeof(jvalue[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "Box", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(AndroidJavaObject))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNIHelper), Member = "CreateJavaProxy", MemberParameters = new object[] { typeof(AndroidJavaProxy) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal IntPtr GetRawProxy()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000076")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5F82C", Offset = "0x1F5F82C", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "FindClass", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GlobalJavaObjectRef), Member = ".ctor", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(_AndroidJNIHelper), Member = "GetMethodID", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static AndroidJavaProxy()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000005")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly AndroidJavaClass javaInterface;

		[global::Cpp2ILInjected.Token(Token = "0x4000006")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal IntPtr proxyObject;

		[global::Cpp2ILInjected.Token(Token = "0x4000007")]
		private static readonly GlobalJavaObjectRef s_JavaLangSystemClass;

		[global::Cpp2ILInjected.Token(Token = "0x4000008")]
		private static readonly IntPtr s_HashCodeMethodID;
	}
}
