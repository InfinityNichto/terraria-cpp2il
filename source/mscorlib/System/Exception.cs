using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Math;

namespace System
{
	// Token: 0x02000114 RID: 276
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000152")]
	[global::System.Serializable]
	[StructLayout(0)]
	public class Exception : global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x06000C8C RID: 3212 RVA: 0x0001695B File Offset: 0x00014B5B
		[global::Cpp2ILInjected.Token(Token = "0x6000D64")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C699E4", Offset = "0x1C699E4", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Exception), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Exception), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SafeSerializationManager), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void Init()
		{
			throw null;
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x0001695E File Offset: 0x00014B5E
		[global::Cpp2ILInjected.Token(Token = "0x6000D65")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C69A54", Offset = "0x1C69A54", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.NoSuitableGraphicsDeviceException", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Math.BigInteger.ModulusRing), Member = "Difference", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(Mono.Math.BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Math.BigInteger), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(Mono.Math.BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.InvalidTimeZoneException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.LockRecursionException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListenerRequest", Member = "SetRequestLine", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ListenerPrefix", Member = "CheckUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InControlException", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.UpaException", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonException", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipException", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zlib.ZlibException", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Math.BigInteger.ModulusRing", Member = "Difference", MemberParameters = new object[] { "Mono.Math.BigInteger", "Mono.Math.BigInteger" }, ReturnType = "Mono.Math.BigInteger")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Math.BigInteger", Member = "op_Subtraction", MemberParameters = new object[] { "Mono.Math.BigInteger", "Mono.Math.BigInteger" }, ReturnType = "Mono.Math.BigInteger")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = "Init", ReturnType = typeof(void))]
		public Exception()
		{
			throw null;
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x00016961 File Offset: 0x00014B61
		[global::Cpp2ILInjected.Token(Token = "0x6000D66")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C69A70", Offset = "0x1C69A70", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 99)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = "Init", ReturnType = typeof(void))]
		public Exception(string message)
		{
			throw null;
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x00016964 File Offset: 0x00014B64
		[global::Cpp2ILInjected.Token(Token = "0x6000D67")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C69AA0", Offset = "0x1C69AA0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.NoSuitableGraphicsDeviceException", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Content.AssetLoadException", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.AggregateException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Collections.Generic.IList<global::System.Exception>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.AggregateException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Collections.Generic.IList<global::System.Runtime.ExceptionServices.ExceptionDispatchInfo>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ApplicationException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.TaskSchedulerException), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InControlException", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonException", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.ExecuteEvents", Member = "Execute", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "UnityEngine.GameObject", "UnityEngine.EventSystems.BaseEventData", "EventFunction`1<T>" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipException", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = "Init", ReturnType = typeof(void))]
		public Exception(string message, global::System.Exception innerException)
		{
			throw null;
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x00016967 File Offset: 0x00014B67
		[global::Cpp2ILInjected.Token(Token = "0x6000D68")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C69AD8", Offset = "0x1C69AD8", Length = "0x45C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.AggregateException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ApplicationException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.InvalidTimeZoneException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.LockRecursionException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.TaskSchedulerException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.AmbiguousImplementationException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.RuntimeWrappedException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonException", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UnityException", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetValueNoThrow", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetInt32", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
		protected Exception(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000C91 RID: 3217 RVA: 0x0001696A File Offset: 0x00014B6A
		[global::Cpp2ILInjected.Token(Token = "0x1700011F")]
		public virtual string Message
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D69")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C69F34", Offset = "0x1C69F34", Length = "0xC4")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.AggregateException), Member = "get_Message", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ArgumentException), Member = "get_Message", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ObjectDisposedException), Member = "get_Message", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MissingMemberException), Member = "get_Message", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.ReflectionTypeLoadException), Member = "CreateString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.SocketException", Member = "get_Message", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlException", Member = "get_Message", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XmlSchemaException", Member = "get_Message", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = "GetClassName", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object[])
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000C92 RID: 3218 RVA: 0x0001696D File Offset: 0x00014B6D
		[global::Cpp2ILInjected.Token(Token = "0x17000120")]
		public virtual global::System.Collections.IDictionary Data
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D6A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C6A02C", Offset = "0x1C6A02C", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ListDictionaryInternal), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x00016970 File Offset: 0x00014B70
		[global::Cpp2ILInjected.Token(Token = "0x6000D6B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C69FF8", Offset = "0x1C69FF8", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Exception), Member = "get_Message", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Exception), Member = "ToString", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Exception), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		private string GetClassName()
		{
			throw null;
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000C94 RID: 3220 RVA: 0x00016973 File Offset: 0x00014B73
		[global::Cpp2ILInjected.Token(Token = "0x17000121")]
		public global::System.Exception InnerException
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D6C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C6A098", Offset = "0x1C6A098", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000C95 RID: 3221 RVA: 0x00016976 File Offset: 0x00014B76
		[global::Cpp2ILInjected.Token(Token = "0x17000122")]
		public virtual string StackTrace
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D6D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C6A0A0", Offset = "0x1C6A0A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.AndroidJavaException", Member = "get_StackTrace", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x00016979 File Offset: 0x00014B79
		[global::Cpp2ILInjected.Token(Token = "0x6000D6E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6A0A8", Offset = "0x1C6A0A8", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Exception), Member = "ToString", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetStackTrace", MemberParameters = new object[]
		{
			typeof(global::System.Exception),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		private string GetStackTrace(bool needFileInfo)
		{
			throw null;
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x0001697C File Offset: 0x00014B7C
		[global::Cpp2ILInjected.Token(Token = "0x6000D6F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6A0FC", Offset = "0x1C6A0FC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TypeLoadException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TypeLoadException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TypeLoadException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.ThreadAbortException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.ThreadInterruptedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.CryptographicException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.CryptographicException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.CryptographicException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.CryptographicUnexpectedOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.CryptographicUnexpectedOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.CryptographicUnexpectedOperationException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.CryptographicUnexpectedOperationException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
		internal void SetErrorCode(int hr)
		{
			throw null;
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000C98 RID: 3224 RVA: 0x0001697F File Offset: 0x00014B7F
		[global::Cpp2ILInjected.Token(Token = "0x17000123")]
		public virtual string Source
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D70")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C6A104", Offset = "0x1C6A104", Length = "0xF0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Diagnostics.StackTrace), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(global::System.Exception),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodBase), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(global::System.Reflection.MethodBase),
				typeof(global::System.Reflection.MethodBase)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x00016982 File Offset: 0x00014B82
		[global::Cpp2ILInjected.Token(Token = "0x6000D71")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6A1F4", Offset = "0x1C6A1F4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.AggregateException), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.SecurityException), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.ReflectionTypeLoadException), Member = "CreateString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x00016985 File Offset: 0x00014B85
		[global::Cpp2ILInjected.Token(Token = "0x6000D72")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6A200", Offset = "0x1C6A200", Length = "0x250")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Exception), Member = "ToString", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = "GetClassName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = "ToString", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_NewLine", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = "GetStackTrace", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private string ToString(bool needFileLineInfo, bool needMessage)
		{
			throw null;
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x00016988 File Offset: 0x00014B88
		[global::Cpp2ILInjected.Token(Token = "0x6000D73")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6A450", Offset = "0x1C6A450", Length = "0x4A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 24)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetStackTrace", MemberParameters = new object[]
		{
			typeof(global::System.Exception),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = "GetClassName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SafeSerializationManager), Member = "get_IsActive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SafeSerializationManager), Member = "CompleteSerialization", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		public virtual void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x0001698B File Offset: 0x00014B8B
		[global::System.Runtime.Serialization.OnDeserialized]
		[global::Cpp2ILInjected.Token(Token = "0x6000D74")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6A8F0", Offset = "0x1C6A8F0", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SafeSerializationManager), Member = "CompleteDeserialization", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SafeSerializationManager), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void OnDeserialized(global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x0001698E File Offset: 0x00014B8E
		[global::Cpp2ILInjected.Token(Token = "0x6000D75")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6A0F4", Offset = "0x1C6A0F4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private string StripFileInfo(string stackTrace, bool isRemoteStackTrace)
		{
			throw null;
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x00016991 File Offset: 0x00014B91
		[global::Cpp2ILInjected.Token(Token = "0x6000D76")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6A968", Offset = "0x1C6A968", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.ExceptionServices.ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal void RestoreExceptionDispatchInfo(global::System.Runtime.ExceptionServices.ExceptionDispatchInfo exceptionDispatchInfo)
		{
			throw null;
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000C9F RID: 3231 RVA: 0x00016994 File Offset: 0x00014B94
		// (set) Token: 0x06000CA0 RID: 3232 RVA: 0x00016997 File Offset: 0x00014B97
		[global::Cpp2ILInjected.Token(Token = "0x17000124")]
		public int HResult
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D77")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C6A9FC", Offset = "0x1C6A9FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000D78")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C6AA04", Offset = "0x1C6AA04", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x0001699A File Offset: 0x00014B9A
		[global::Cpp2ILInjected.Token(Token = "0x6000D79")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6A090", Offset = "0x1C6A090", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.BadImageFormatException), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.InteropServices.ExternalException), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.InteropServices.COMException), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileLoadException), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileNotFoundException), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectPropertyDescriptor", Member = "GetValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.StackTraceUtility", Member = "ExtractStringFromExceptionInternal", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		public new global::System.Type GetType()
		{
			throw null;
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x0001699D File Offset: 0x00014B9D
		[global::Cpp2ILInjected.Token(Token = "0x6000D7A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6AA0C", Offset = "0x1C6AA0C", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.ThreadAbortException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.ThreadInterruptedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static string GetMessageFromNativeResources(global::System.Exception.ExceptionMessageKind kind)
		{
			throw null;
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x000169A0 File Offset: 0x00014BA0
		[global::Cpp2ILInjected.Token(Token = "0x6000D7B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6AA90", Offset = "0x1C6AA90", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.RealProxy), Member = "PrivateInvoke", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Remoting.Proxies.RealProxy),
			typeof(global::System.Runtime.Remoting.Messaging.IMessage),
			typeof(ref global::System.Exception),
			typeof(ref object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_NewLine", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal global::System.Exception FixRemotingException()
		{
			throw null;
		}

		// Token: 0x06000CA4 RID: 3236
		[global::Cpp2ILInjected.Token(Token = "0x6000D7C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6AB78", Offset = "0x1C6AB78", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.OSSpecificSynchronizationContext), Member = "InvocationEntry", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern void ReportUnhandledException(global::System.Exception exception);

		// Token: 0x06000CA5 RID: 3237 RVA: 0x000169A3 File Offset: 0x00014BA3
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000D7D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6AB7C", Offset = "0x1C6AB7C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static Exception()
		{
			throw null;
		}

		// Token: 0x0400039A RID: 922
		[global::System.Runtime.Serialization.OptionalField]
		[global::Cpp2ILInjected.Token(Token = "0x400051F")]
		private static object s_EDILock;

		// Token: 0x0400039B RID: 923
		[global::Cpp2ILInjected.Token(Token = "0x4000520")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string _className;

		// Token: 0x0400039C RID: 924
		[global::Cpp2ILInjected.Token(Token = "0x4000521")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal string _message;

		// Token: 0x0400039D RID: 925
		[global::Cpp2ILInjected.Token(Token = "0x4000522")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private global::System.Collections.IDictionary _data;

		// Token: 0x0400039E RID: 926
		[global::Cpp2ILInjected.Token(Token = "0x4000523")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private global::System.Exception _innerException;

		// Token: 0x0400039F RID: 927
		[global::Cpp2ILInjected.Token(Token = "0x4000524")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string _helpURL;

		// Token: 0x040003A0 RID: 928
		[global::Cpp2ILInjected.Token(Token = "0x4000525")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private object _stackTrace;

		// Token: 0x040003A1 RID: 929
		[global::Cpp2ILInjected.Token(Token = "0x4000526")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private string _stackTraceString;

		// Token: 0x040003A2 RID: 930
		[global::Cpp2ILInjected.Token(Token = "0x4000527")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private string _remoteStackTraceString;

		// Token: 0x040003A3 RID: 931
		[global::Cpp2ILInjected.Token(Token = "0x4000528")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private int _remoteStackIndex;

		// Token: 0x040003A4 RID: 932
		[global::Cpp2ILInjected.Token(Token = "0x4000529")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private object _dynamicMethods;

		// Token: 0x040003A5 RID: 933
		[global::Cpp2ILInjected.Token(Token = "0x400052A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		internal int _HResult;

		// Token: 0x040003A6 RID: 934
		[global::Cpp2ILInjected.Token(Token = "0x400052B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private string _source;

		// Token: 0x040003A7 RID: 935
		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 4)]
		[global::Cpp2ILInjected.Token(Token = "0x400052C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private global::System.Runtime.Serialization.SafeSerializationManager _safeSerializationManager;

		// Token: 0x040003A8 RID: 936
		[global::Cpp2ILInjected.Token(Token = "0x400052D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		internal global::System.Diagnostics.StackTrace[] captured_traces;

		// Token: 0x040003A9 RID: 937
		[global::Cpp2ILInjected.Token(Token = "0x400052E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private global::System.IntPtr[] native_trace_ips;

		// Token: 0x040003AA RID: 938
		[global::Cpp2ILInjected.Token(Token = "0x400052F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private int caught_in_unmanaged;

		// Token: 0x040003AB RID: 939
		[global::Cpp2ILInjected.Token(Token = "0x4000530")]
		private const int _COMPlusExceptionCode = -532462766;

		// Token: 0x02000592 RID: 1426
		[global::Cpp2ILInjected.Token(Token = "0x2000153")]
		internal enum ExceptionMessageKind
		{
			// Token: 0x0400182D RID: 6189
			[global::Cpp2ILInjected.Token(Token = "0x4000532")]
			ThreadAbort = 1,
			// Token: 0x0400182E RID: 6190
			[global::Cpp2ILInjected.Token(Token = "0x4000533")]
			ThreadInterrupted,
			// Token: 0x0400182F RID: 6191
			[global::Cpp2ILInjected.Token(Token = "0x4000534")]
			OutOfMemory
		}
	}
}
