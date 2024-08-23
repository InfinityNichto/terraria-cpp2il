using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x0200029A RID: 666
	[global::Cpp2ILInjected.Token(Token = "0x2000391")]
	public class LicFileLicenseProvider : LicenseProvider
	{
		// Token: 0x06001579 RID: 5497 RVA: 0x00006AAC File Offset: 0x00004CAC
		[global::Cpp2ILInjected.Token(Token = "0x60017C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4D7B4", Offset = "0x1E4D7B4", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		protected virtual bool IsKeyValid(string key, Type type)
		{
			throw null;
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x00006AAF File Offset: 0x00004CAF
		[global::Cpp2ILInjected.Token(Token = "0x60017C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4D7F0", Offset = "0x1E4D7F0", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(IFormatProvider),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected virtual string GetKey(Type type)
		{
			throw null;
		}

		// Token: 0x0600157B RID: 5499 RVA: 0x00006AB2 File Offset: 0x00004CB2
		[global::Cpp2ILInjected.Token(Token = "0x60017C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4D884", Offset = "0x1E4D884", Length = "0x3D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetDirectoryName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(FileMode),
			typeof(FileAccess),
			typeof(FileShare)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public override License GetLicense(LicenseContext context, Type type, object instance, bool allowExceptions)
		{
			throw null;
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x00006AB5 File Offset: 0x00004CB5
		[global::Cpp2ILInjected.Token(Token = "0x60017C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4DC84", Offset = "0x1E4DC84", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public LicFileLicenseProvider()
		{
			throw null;
		}

		// Token: 0x02000459 RID: 1113
		[global::Cpp2ILInjected.Token(Token = "0x2000392")]
		private class LicFileLicense : License
		{
			// Token: 0x06001EE1 RID: 7905 RVA: 0x00008522 File Offset: 0x00006722
			[global::Cpp2ILInjected.Token(Token = "0x60017C8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4DC58", Offset = "0x1E4DC58", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public LicFileLicense(LicFileLicenseProvider owner, string key)
			{
				throw null;
			}

			// Token: 0x1700074D RID: 1869
			// (get) Token: 0x06001EE2 RID: 7906 RVA: 0x00008525 File Offset: 0x00006725
			[global::Cpp2ILInjected.Token(Token = "0x1700056C")]
			public override string LicenseKey
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60017C9")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E4DC9C", Offset = "0x1E4DC9C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06001EE3 RID: 7907 RVA: 0x00008528 File Offset: 0x00006728
			[global::Cpp2ILInjected.Token(Token = "0x60017CA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4DCA4", Offset = "0x1E4DCA4", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override void Dispose()
			{
				throw null;
			}

			// Token: 0x0400138C RID: 5004
			[global::Cpp2ILInjected.Token(Token = "0x400122D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private LicFileLicenseProvider _owner;

			// Token: 0x0400138D RID: 5005
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x400122E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private readonly string <LicenseKey>k__BackingField;
		}
	}
}
