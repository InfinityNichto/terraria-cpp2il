using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.IO
{
	// Token: 0x0200046D RID: 1133
	[global::Cpp2ILInjected.Token(Token = "0x2000533")]
	[global::System.Serializable]
	public class FileLoadException : IOException
	{
		// Token: 0x06002492 RID: 9362 RVA: 0x0001AAC2 File Offset: 0x00018CC2
		[global::Cpp2ILInjected.Token(Token = "0x6002736")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B95CD8", Offset = "0x1B95CD8", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public FileLoadException()
		{
			throw null;
		}

		// Token: 0x06002493 RID: 9363 RVA: 0x0001AAC5 File Offset: 0x00018CC5
		[global::Cpp2ILInjected.Token(Token = "0x6002737")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B95D34", Offset = "0x1B95D34", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.AssemblyName), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public FileLoadException(string message)
		{
			throw null;
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06002494 RID: 9364 RVA: 0x0001AAC8 File Offset: 0x00018CC8
		[global::Cpp2ILInjected.Token(Token = "0x170005A3")]
		public override string Message
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002738")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B95D58", Offset = "0x1B95D58", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileLoadException), Member = "FormatFileLoadExceptionMessage", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int)
			}, ReturnType = typeof(string))]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06002495 RID: 9365 RVA: 0x0001AACB File Offset: 0x00018CCB
		[global::Cpp2ILInjected.Token(Token = "0x170005A4")]
		public string FileName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6002739")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B95DF0", Offset = "0x1B95DF0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06002496 RID: 9366 RVA: 0x0001AACE File Offset: 0x00018CCE
		[global::Cpp2ILInjected.Token(Token = "0x170005A5")]
		public string FusionLog
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600273A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B95DF8", Offset = "0x1B95DF8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002497 RID: 9367 RVA: 0x0001AAD1 File Offset: 0x00018CD1
		[global::Cpp2ILInjected.Token(Token = "0x600273B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B95E00", Offset = "0x1B95E00", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_NewLine", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06002498 RID: 9368 RVA: 0x0001AAD4 File Offset: 0x00018CD4
		[global::Cpp2ILInjected.Token(Token = "0x600273C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B95FDC", Offset = "0x1B95FDC", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected FileLoadException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06002499 RID: 9369 RVA: 0x0001AAD7 File Offset: 0x00018CD7
		[global::Cpp2ILInjected.Token(Token = "0x600273D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9608C", Offset = "0x1B9608C", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x0600249A RID: 9370 RVA: 0x0001AADA File Offset: 0x00018CDA
		[global::Cpp2ILInjected.Token(Token = "0x600273E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B95D7C", Offset = "0x1B95D7C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.BadImageFormatException), Member = "SetMessageField", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileLoadException), Member = "get_Message", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileNotFoundException), Member = "SetMessageField", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static string FormatFileLoadExceptionMessage(string fileName, int hResult)
		{
			throw null;
		}

		// Token: 0x04001249 RID: 4681
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001569")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private readonly string <FileName>k__BackingField;

		// Token: 0x0400124A RID: 4682
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400156A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private readonly string <FusionLog>k__BackingField;
	}
}
