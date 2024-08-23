using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	// Token: 0x02000033 RID: 51
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000035")]
	public class JsonSerializer
	{
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060001EC RID: 492 RVA: 0x00002666 File Offset: 0x00000866
		// (remove) Token: 0x060001ED RID: 493 RVA: 0x00002669 File Offset: 0x00000869
		[global::Cpp2ILInjected.Token(Token = "0x14000003")]
		public virtual event EventHandler<ErrorEventArgs> Error
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60001EE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC7900", Offset = "0x1CC7900", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60001EF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC79B0", Offset = "0x1CC79B0", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001EE RID: 494 RVA: 0x0000266C File Offset: 0x0000086C
		// (set) Token: 0x060001EF RID: 495 RVA: 0x0000266F File Offset: 0x0000086F
		[global::Cpp2ILInjected.Token(Token = "0x17000065")]
		public virtual IReferenceResolver ReferenceResolver
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001F0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC7A60", Offset = "0x1CC7A60", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001F1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC7AC8", Offset = "0x1CC7AC8", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x00002672 File Offset: 0x00000872
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x00002675 File Offset: 0x00000875
		[global::Cpp2ILInjected.Token(Token = "0x17000066")]
		public virtual SerializationBinder Binder
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001F2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC7B40", Offset = "0x1CC7B40", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001F3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC7B48", Offset = "0x1CC7B48", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x00002678 File Offset: 0x00000878
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x0000267B File Offset: 0x0000087B
		[global::Cpp2ILInjected.Token(Token = "0x17000067")]
		public virtual ITraceWriter TraceWriter
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001F4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC7BC0", Offset = "0x1CC7BC0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001F5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC7BC8", Offset = "0x1CC7BC8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x0000267E File Offset: 0x0000087E
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x00002681 File Offset: 0x00000881
		[global::Cpp2ILInjected.Token(Token = "0x17000068")]
		public virtual IEqualityComparer EqualityComparer
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001F6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC7BD0", Offset = "0x1CC7BD0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001F7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC7BD8", Offset = "0x1CC7BD8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x00002684 File Offset: 0x00000884
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x00002687 File Offset: 0x00000887
		[global::Cpp2ILInjected.Token(Token = "0x17000069")]
		public virtual TypeNameHandling TypeNameHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001F8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC7BE0", Offset = "0x1CC7BE0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001F9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC7BE8", Offset = "0x1CC7BE8", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x0000268A File Offset: 0x0000088A
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x0000268D File Offset: 0x0000088D
		[global::Cpp2ILInjected.Token(Token = "0x1700006A")]
		public virtual FormatterAssemblyStyle TypeNameAssemblyFormat
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001FA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC7C48", Offset = "0x1CC7C48", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001FB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC7C50", Offset = "0x1CC7C50", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00002690 File Offset: 0x00000890
		// (set) Token: 0x060001FB RID: 507 RVA: 0x00002693 File Offset: 0x00000893
		[global::Cpp2ILInjected.Token(Token = "0x1700006B")]
		public virtual PreserveReferencesHandling PreserveReferencesHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001FC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC7CB0", Offset = "0x1CC7CB0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001FD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC7CB8", Offset = "0x1CC7CB8", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001FC RID: 508 RVA: 0x00002696 File Offset: 0x00000896
		// (set) Token: 0x060001FD RID: 509 RVA: 0x00002699 File Offset: 0x00000899
		[global::Cpp2ILInjected.Token(Token = "0x1700006C")]
		public virtual ReferenceLoopHandling ReferenceLoopHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001FE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC7D18", Offset = "0x1CC7D18", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001FF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC7D20", Offset = "0x1CC7D20", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001FE RID: 510 RVA: 0x0000269C File Offset: 0x0000089C
		// (set) Token: 0x060001FF RID: 511 RVA: 0x0000269F File Offset: 0x0000089F
		[global::Cpp2ILInjected.Token(Token = "0x1700006D")]
		public virtual MissingMemberHandling MissingMemberHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000200")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC7D80", Offset = "0x1CC7D80", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000201")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC7D88", Offset = "0x1CC7D88", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000200 RID: 512 RVA: 0x000026A2 File Offset: 0x000008A2
		// (set) Token: 0x06000201 RID: 513 RVA: 0x000026A5 File Offset: 0x000008A5
		[global::Cpp2ILInjected.Token(Token = "0x1700006E")]
		public virtual NullValueHandling NullValueHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000202")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC7DE8", Offset = "0x1CC7DE8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000203")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC7DF0", Offset = "0x1CC7DF0", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000202 RID: 514 RVA: 0x000026A8 File Offset: 0x000008A8
		// (set) Token: 0x06000203 RID: 515 RVA: 0x000026AB File Offset: 0x000008AB
		[global::Cpp2ILInjected.Token(Token = "0x1700006F")]
		public virtual DefaultValueHandling DefaultValueHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000204")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC7E50", Offset = "0x1CC7E50", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000205")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC7E58", Offset = "0x1CC7E58", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000204 RID: 516 RVA: 0x000026AE File Offset: 0x000008AE
		// (set) Token: 0x06000205 RID: 517 RVA: 0x000026B1 File Offset: 0x000008B1
		[global::Cpp2ILInjected.Token(Token = "0x17000070")]
		public virtual ObjectCreationHandling ObjectCreationHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000206")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC7EB8", Offset = "0x1CC7EB8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000207")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC7EC0", Offset = "0x1CC7EC0", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000206 RID: 518 RVA: 0x000026B4 File Offset: 0x000008B4
		// (set) Token: 0x06000207 RID: 519 RVA: 0x000026B7 File Offset: 0x000008B7
		[global::Cpp2ILInjected.Token(Token = "0x17000071")]
		public virtual ConstructorHandling ConstructorHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000208")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC7F20", Offset = "0x1CC7F20", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000209")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC7F28", Offset = "0x1CC7F28", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000208 RID: 520 RVA: 0x000026BA File Offset: 0x000008BA
		// (set) Token: 0x06000209 RID: 521 RVA: 0x000026BD File Offset: 0x000008BD
		[global::Cpp2ILInjected.Token(Token = "0x17000072")]
		public virtual MetadataPropertyHandling MetadataPropertyHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x600020A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC7F88", Offset = "0x1CC7F88", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600020B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC7F90", Offset = "0x1CC7F90", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600020A RID: 522 RVA: 0x000026C0 File Offset: 0x000008C0
		[global::Cpp2ILInjected.Token(Token = "0x17000073")]
		public virtual JsonConverterCollection Converters
		{
			[global::Cpp2ILInjected.Token(Token = "0x600020C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC7FF0", Offset = "0x1CC7FF0", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConverterCollection), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600020B RID: 523 RVA: 0x000026C3 File Offset: 0x000008C3
		// (set) Token: 0x0600020C RID: 524 RVA: 0x000026C6 File Offset: 0x000008C6
		[global::Cpp2ILInjected.Token(Token = "0x17000074")]
		public virtual IContractResolver ContractResolver
		{
			[global::Cpp2ILInjected.Token(Token = "0x600020D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC8050", Offset = "0x1CC8050", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600020E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC8058", Offset = "0x1CC8058", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600020D RID: 525 RVA: 0x000026C9 File Offset: 0x000008C9
		// (set) Token: 0x0600020E RID: 526 RVA: 0x000026CC File Offset: 0x000008CC
		[global::Cpp2ILInjected.Token(Token = "0x17000075")]
		public virtual StreamingContext Context
		{
			[global::Cpp2ILInjected.Token(Token = "0x600020F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC80F0", Offset = "0x1CC80F0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000210")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC80FC", Offset = "0x1CC80FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600020F RID: 527 RVA: 0x000026CF File Offset: 0x000008CF
		// (set) Token: 0x06000210 RID: 528 RVA: 0x000026D2 File Offset: 0x000008D2
		[global::Cpp2ILInjected.Token(Token = "0x17000076")]
		public virtual Formatting Formatting
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000211")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC8104", Offset = "0x1CC8104", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000212")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC8154", Offset = "0x1CC8154", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = ".ctor", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000211 RID: 529 RVA: 0x000026D5 File Offset: 0x000008D5
		// (set) Token: 0x06000212 RID: 530 RVA: 0x000026D8 File Offset: 0x000008D8
		[global::Cpp2ILInjected.Token(Token = "0x17000077")]
		public virtual DateFormatHandling DateFormatHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000213")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC81BC", Offset = "0x1CC81BC", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000214")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC820C", Offset = "0x1CC820C", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = ".ctor", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000213 RID: 531 RVA: 0x000026DB File Offset: 0x000008DB
		// (set) Token: 0x06000214 RID: 532 RVA: 0x000026DE File Offset: 0x000008DE
		[global::Cpp2ILInjected.Token(Token = "0x17000078")]
		public virtual DateTimeZoneHandling DateTimeZoneHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000215")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC8274", Offset = "0x1CC8274", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000216")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC82C8", Offset = "0x1CC82C8", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = ".ctor", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000215 RID: 533 RVA: 0x000026E1 File Offset: 0x000008E1
		// (set) Token: 0x06000216 RID: 534 RVA: 0x000026E4 File Offset: 0x000008E4
		[global::Cpp2ILInjected.Token(Token = "0x17000079")]
		public virtual DateParseHandling DateParseHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000217")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC8330", Offset = "0x1CC8330", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000218")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC8380", Offset = "0x1CC8380", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = ".ctor", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000217 RID: 535 RVA: 0x000026E7 File Offset: 0x000008E7
		// (set) Token: 0x06000218 RID: 536 RVA: 0x000026EA File Offset: 0x000008EA
		[global::Cpp2ILInjected.Token(Token = "0x1700007A")]
		public virtual FloatParseHandling FloatParseHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000219")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC83E8", Offset = "0x1CC83E8", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600021A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC8438", Offset = "0x1CC8438", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = ".ctor", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000219 RID: 537 RVA: 0x000026ED File Offset: 0x000008ED
		// (set) Token: 0x0600021A RID: 538 RVA: 0x000026F0 File Offset: 0x000008F0
		[global::Cpp2ILInjected.Token(Token = "0x1700007B")]
		public virtual FloatFormatHandling FloatFormatHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x600021B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC84A0", Offset = "0x1CC84A0", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600021C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC84F0", Offset = "0x1CC84F0", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = ".ctor", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600021B RID: 539 RVA: 0x000026F3 File Offset: 0x000008F3
		// (set) Token: 0x0600021C RID: 540 RVA: 0x000026F6 File Offset: 0x000008F6
		[global::Cpp2ILInjected.Token(Token = "0x1700007C")]
		public virtual StringEscapeHandling StringEscapeHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x600021D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC8558", Offset = "0x1CC8558", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600021E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC85A8", Offset = "0x1CC85A8", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = ".ctor", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600021D RID: 541 RVA: 0x000026F9 File Offset: 0x000008F9
		// (set) Token: 0x0600021E RID: 542 RVA: 0x000026FC File Offset: 0x000008FC
		[global::Cpp2ILInjected.Token(Token = "0x1700007D")]
		public virtual string DateFormatString
		{
			[global::Cpp2ILInjected.Token(Token = "0x600021F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC8610", Offset = "0x1CC8610", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000220")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC8660", Offset = "0x1CC8660", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600021F RID: 543 RVA: 0x000026FF File Offset: 0x000008FF
		// (set) Token: 0x06000220 RID: 544 RVA: 0x00002702 File Offset: 0x00000902
		[global::Cpp2ILInjected.Token(Token = "0x1700007E")]
		public virtual CultureInfo Culture
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000221")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC8670", Offset = "0x1CC8670", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000222")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC86D4", Offset = "0x1CC86D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000221 RID: 545 RVA: 0x00002705 File Offset: 0x00000905
		// (set) Token: 0x06000222 RID: 546 RVA: 0x00002708 File Offset: 0x00000908
		[global::Cpp2ILInjected.Token(Token = "0x1700007F")]
		public virtual int? MaxDepth
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000223")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC86DC", Offset = "0x1CC86DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000224")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC86E4", Offset = "0x1CC86E4", Length = "0xC4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000223 RID: 547 RVA: 0x0000270B File Offset: 0x0000090B
		// (set) Token: 0x06000224 RID: 548 RVA: 0x0000270E File Offset: 0x0000090E
		[global::Cpp2ILInjected.Token(Token = "0x17000080")]
		public virtual bool CheckAdditionalContent
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000225")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC87A8", Offset = "0x1CC87A8", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000226")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC8804", Offset = "0x1CC8804", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = ".ctor", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00002711 File Offset: 0x00000911
		[global::Cpp2ILInjected.Token(Token = "0x6000227")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC6C24", Offset = "0x1CC6C24", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal bool IsCheckAdditionalContentSet()
		{
			throw null;
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00002714 File Offset: 0x00000914
		[global::Cpp2ILInjected.Token(Token = "0x6000228")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC886C", Offset = "0x1CC886C", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "Create", ReturnType = typeof(JsonSerializer))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerProxy), Member = ".ctor", MemberParameters = new object[] { typeof(JsonSerializerInternalReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerProxy), Member = ".ctor", MemberParameters = new object[] { typeof(JsonSerializerInternalWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public JsonSerializer()
		{
			throw null;
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00002717 File Offset: 0x00000917
		[global::Cpp2ILInjected.Token(Token = "0x6000229")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC899C", Offset = "0x1CC899C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "Create", MemberParameters = new object[] { typeof(JsonSerializerSettings) }, ReturnType = typeof(JsonSerializer))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static JsonSerializer Create()
		{
			throw null;
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0000271A File Offset: 0x0000091A
		[global::Cpp2ILInjected.Token(Token = "0x600022A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC89EC", Offset = "0x1CC89EC", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "LocalUser", Member = "LoadPersistantData", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "LocalUser", Member = "SavePersistantData", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.Preferences", Member = "Load", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.Preferences", Member = "Save", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Achievements.AchievementManager", Member = "Save", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Achievements.AchievementManager", Member = "Load", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "CreateDefault", ReturnType = typeof(JsonSerializer))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "Create", ReturnType = typeof(JsonSerializer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "ApplySerializerSettings", MemberParameters = new object[]
		{
			typeof(JsonSerializer),
			typeof(JsonSerializerSettings)
		}, ReturnType = typeof(void))]
		public static JsonSerializer Create(JsonSerializerSettings settings)
		{
			throw null;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0000271D File Offset: 0x0000091D
		[global::Cpp2ILInjected.Token(Token = "0x600022B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC8FD0", Offset = "0x1CC8FD0", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "CreateDefault", MemberParameters = new object[] { typeof(JsonSerializerSettings) }, ReturnType = typeof(JsonSerializer))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "FromObject", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(JObject))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JArray), Member = "FromObject", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(JArray))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "FromObject", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JValue), Member = "WriteTo", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(JsonConverter[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "Create", MemberParameters = new object[] { typeof(JsonSerializerSettings) }, ReturnType = typeof(JsonSerializer))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static JsonSerializer CreateDefault()
		{
			throw null;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00002720 File Offset: 0x00000920
		[global::Cpp2ILInjected.Token(Token = "0x600022C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC6538", Offset = "0x1CC6538", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(JsonSerializerSettings)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(Formatting),
			typeof(JsonSerializerSettings)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "DeserializeObject", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type),
			typeof(JsonSerializerSettings)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "PopulateObject", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(JsonSerializerSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "CreateDefault", ReturnType = typeof(JsonSerializer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "ApplySerializerSettings", MemberParameters = new object[]
		{
			typeof(JsonSerializer),
			typeof(JsonSerializerSettings)
		}, ReturnType = typeof(void))]
		public static JsonSerializer CreateDefault(JsonSerializerSettings settings)
		{
			throw null;
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00002723 File Offset: 0x00000923
		[global::Cpp2ILInjected.Token(Token = "0x600022D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC8A20", Offset = "0x1CC8A20", Length = "0x5B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "Create", MemberParameters = new object[] { typeof(JsonSerializerSettings) }, ReturnType = typeof(JsonSerializer))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "CreateDefault", MemberParameters = new object[] { typeof(JsonSerializerSettings) }, ReturnType = typeof(JsonSerializer))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionUtils), Member = "IsNullOrEmpty", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Collections.Generic.ICollection`1<T>" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collection<>), Member = "Insert", MemberParameters = new object[]
		{
			typeof(int),
			"T"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerSettings), Member = "get_TypeNameHandling", ReturnType = typeof(TypeNameHandling))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerSettings), Member = "get_MetadataPropertyHandling", ReturnType = typeof(MetadataPropertyHandling))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerSettings), Member = "get_TypeNameAssemblyFormat", ReturnType = typeof(FormatterAssemblyStyle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerSettings), Member = "get_PreserveReferencesHandling", ReturnType = typeof(PreserveReferencesHandling))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerSettings), Member = "get_ReferenceLoopHandling", ReturnType = typeof(ReferenceLoopHandling))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerSettings), Member = "get_MissingMemberHandling", ReturnType = typeof(MissingMemberHandling))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerSettings), Member = "get_ObjectCreationHandling", ReturnType = typeof(ObjectCreationHandling))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerSettings), Member = "get_NullValueHandling", ReturnType = typeof(NullValueHandling))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerSettings), Member = "get_DefaultValueHandling", ReturnType = typeof(DefaultValueHandling))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerSettings), Member = "get_ConstructorHandling", ReturnType = typeof(ConstructorHandling))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerSettings), Member = "get_Context", ReturnType = typeof(StreamingContext))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		private static void ApplySerializerSettings(JsonSerializer serializer, JsonSerializerSettings settings)
		{
			throw null;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00002726 File Offset: 0x00000926
		[global::Cpp2ILInjected.Token(Token = "0x600022E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC9074", Offset = "0x1CC9074", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTextReader), Member = ".ctor", MemberParameters = new object[] { typeof(TextReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Populate(TextReader reader, object target)
		{
			throw null;
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00002729 File Offset: 0x00000929
		[global::Cpp2ILInjected.Token(Token = "0x600022F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC6F3C", Offset = "0x1CC6F3C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerProxy), Member = "PopulateInternal", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomCreationConverter<>), Member = "ReadJson", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Populate(JsonReader reader, object target)
		{
			throw null;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0000272C File Offset: 0x0000092C
		[global::Cpp2ILInjected.Token(Token = "0x6000230")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC90F0", Offset = "0x1CC90F0", Length = "0x280")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "SetupReader", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(ref CultureInfo),
			typeof(ref DateTimeZoneHandling?),
			typeof(ref DateParseHandling?),
			typeof(ref FloatParseHandling?),
			typeof(ref int?),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TraceJsonReader), Member = ".ctor", MemberParameters = new object[] { typeof(JsonReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = ".ctor", MemberParameters = new object[] { typeof(JsonSerializer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "Populate", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TraceJsonReader), Member = "GetDeserializedJsonMessage", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "ResetReader", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(CultureInfo),
			typeof(DateTimeZoneHandling?),
			typeof(DateParseHandling?),
			typeof(FloatParseHandling?),
			typeof(int?),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal virtual void PopulateInternal(JsonReader reader, object target)
		{
			throw null;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x0000272F File Offset: 0x0000092F
		[global::Cpp2ILInjected.Token(Token = "0x6000231")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC9824", Offset = "0x1CC9824", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public object Deserialize(JsonReader reader)
		{
			throw null;
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00002732 File Offset: 0x00000932
		[global::Cpp2ILInjected.Token(Token = "0x6000232")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC9838", Offset = "0x1CC9838", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTextReader), Member = ".ctor", MemberParameters = new object[] { typeof(TextReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public object Deserialize(TextReader reader, Type objectType)
		{
			throw null;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00002735 File Offset: 0x00000935
		[global::Cpp2ILInjected.Token(Token = "0x6000233")]
		[global::Cpp2ILInjected.Address(RVA = "0x158E6AC", Offset = "0x158E6AC", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexConverter), Member = "ReadRegexObject", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonSerializer)
		}, ReturnType = typeof(Regex))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public T Deserialize<T>(JsonReader reader)
		{
			throw null;
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00002738 File Offset: 0x00000938
		[global::Cpp2ILInjected.Token(Token = "0x6000234")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC6C60", Offset = "0x1CC6C60", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "Deserialize", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(JsonReader) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerProxy), Member = "DeserializeInternal", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(JsonSerializer)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HashSetConverter), Member = "ReadJson", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyValuePairConverter), Member = "ReadJson", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public object Deserialize(JsonReader reader, Type objectType)
		{
			throw null;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0000273B File Offset: 0x0000093B
		[global::Cpp2ILInjected.Token(Token = "0x6000235")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC98B4", Offset = "0x1CC98B4", Length = "0x27C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "SetupReader", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(ref CultureInfo),
			typeof(ref DateTimeZoneHandling?),
			typeof(ref DateParseHandling?),
			typeof(ref FloatParseHandling?),
			typeof(ref int?),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TraceJsonReader), Member = ".ctor", MemberParameters = new object[] { typeof(JsonReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = ".ctor", MemberParameters = new object[] { typeof(JsonSerializer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TraceJsonReader), Member = "GetDeserializedJsonMessage", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "ResetReader", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(CultureInfo),
			typeof(DateTimeZoneHandling?),
			typeof(DateParseHandling?),
			typeof(FloatParseHandling?),
			typeof(int?),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal virtual object DeserializeInternal(JsonReader reader, Type objectType)
		{
			throw null;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0000273E File Offset: 0x0000093E
		[global::Cpp2ILInjected.Token(Token = "0x6000236")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC9370", Offset = "0x1CC9370", Length = "0x35C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "PopulateInternal", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "DeserializeInternal", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "get_Culture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = ".ctor", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "set_DateTimeZoneHandling", MemberParameters = new object[] { typeof(DateTimeZoneHandling) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "set_DateParseHandling", MemberParameters = new object[] { typeof(DateParseHandling) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "set_FloatParseHandling", MemberParameters = new object[] { typeof(FloatParseHandling) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "set_MaxDepth", MemberParameters = new object[] { typeof(int?) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultContractResolver), Member = "GetState", ReturnType = typeof(DefaultContractResolverState))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private void SetupReader(JsonReader reader, out CultureInfo previousCulture, out DateTimeZoneHandling? previousDateTimeZoneHandling, out DateParseHandling? previousDateParseHandling, out FloatParseHandling? previousFloatParseHandling, out int? previousMaxDepth, out string previousDateFormatString)
		{
			throw null;
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00002741 File Offset: 0x00000941
		[global::Cpp2ILInjected.Token(Token = "0x6000237")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC96CC", Offset = "0x1CC96CC", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "PopulateInternal", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "DeserializeInternal", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "set_DateTimeZoneHandling", MemberParameters = new object[] { typeof(DateTimeZoneHandling) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "set_DateParseHandling", MemberParameters = new object[] { typeof(DateParseHandling) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "set_FloatParseHandling", MemberParameters = new object[] { typeof(FloatParseHandling) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "set_MaxDepth", MemberParameters = new object[] { typeof(int?) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void ResetReader(JsonReader reader, CultureInfo previousCulture, DateTimeZoneHandling? previousDateTimeZoneHandling, DateParseHandling? previousDateParseHandling, FloatParseHandling? previousFloatParseHandling, int? previousMaxDepth, string previousDateFormatString)
		{
			throw null;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00002744 File Offset: 0x00000944
		[global::Cpp2ILInjected.Token(Token = "0x6000238")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC9B30", Offset = "0x1CC9B30", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTextWriter), Member = ".ctor", MemberParameters = new object[] { typeof(TextWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Serialize(TextWriter textWriter, object value)
		{
			throw null;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00002747 File Offset: 0x00000947
		[global::Cpp2ILInjected.Token(Token = "0x6000239")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC67E8", Offset = "0x1CC67E8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyValuePairConverter), Member = "WriteJson", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Serialize(JsonWriter jsonWriter, object value, Type objectType)
		{
			throw null;
		}

		// Token: 0x06000238 RID: 568 RVA: 0x0000274A File Offset: 0x0000094A
		[global::Cpp2ILInjected.Token(Token = "0x600023A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC9BC4", Offset = "0x1CC9BC4", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTextWriter), Member = ".ctor", MemberParameters = new object[] { typeof(TextWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Serialize(TextWriter textWriter, object value, Type objectType)
		{
			throw null;
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0000274D File Offset: 0x0000094D
		[global::Cpp2ILInjected.Token(Token = "0x600023B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC9BB0", Offset = "0x1CC9BB0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "LocalUser", Member = "SavePersistantData", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.Preferences", Member = "Save", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Achievements.AchievementManager", Member = "Save", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerProxy), Member = "SerializeInternal", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "FromObjectInternal", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexConverter), Member = "WriteJson", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(Regex),
			typeof(JsonSerializer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Serialize(JsonWriter jsonWriter, object value)
		{
			throw null;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00002750 File Offset: 0x00000950
		[global::Cpp2ILInjected.Token(Token = "0x600023C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC9C50", Offset = "0x1CC9C50", Length = "0x550")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = ".ctor", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "set_Formatting", MemberParameters = new object[] { typeof(Formatting) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "set_DateFormatHandling", MemberParameters = new object[] { typeof(DateFormatHandling) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "set_DateTimeZoneHandling", MemberParameters = new object[] { typeof(DateTimeZoneHandling) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "set_FloatFormatHandling", MemberParameters = new object[] { typeof(FloatFormatHandling) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "set_StringEscapeHandling", MemberParameters = new object[] { typeof(StringEscapeHandling) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "get_Culture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TraceJsonWriter), Member = ".ctor", MemberParameters = new object[] { typeof(JsonWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = ".ctor", MemberParameters = new object[] { typeof(JsonSerializer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TraceJsonWriter), Member = "GetSerializedJsonMessage", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		internal virtual void SerializeInternal(JsonWriter jsonWriter, object value, Type objectType)
		{
			throw null;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00002753 File Offset: 0x00000953
		[global::Cpp2ILInjected.Token(Token = "0x600023D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC7A64", Offset = "0x1CC7A64", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ReadMetadataPropertiesToken", MemberParameters = new object[]
		{
			typeof(JTokenReader),
			typeof(ref Type),
			typeof(ref JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(object),
			typeof(ref object),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ReadMetadataProperties", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(ref Type),
			typeof(ref JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(object),
			typeof(ref object),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "AddReference", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "ShouldWriteReference", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonProperty),
			typeof(JsonContract),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "GetReference", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultReferenceResolver), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal IReferenceResolver GetReferenceResolver()
		{
			throw null;
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00002756 File Offset: 0x00000956
		[global::Cpp2ILInjected.Token(Token = "0x600023E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCA1A0", Offset = "0x1CCA1A0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "GetConverter", MemberParameters = new object[]
		{
			typeof(JsonContract),
			typeof(JsonConverter),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(JsonConverter))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeValue", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		internal JsonConverter GetMatchingConverter(Type type)
		{
			throw null;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00002759 File Offset: 0x00000959
		[global::Cpp2ILInjected.Token(Token = "0x600023F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCA1A8", Offset = "0x1CCA1A8", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "InitializeContract", MemberParameters = new object[] { typeof(JsonContract) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JValue), Member = "WriteTo", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(JsonConverter[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static JsonConverter GetMatchingConverter(IList<JsonConverter> converters, Type objectType)
		{
			throw null;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0000275C File Offset: 0x0000095C
		[global::Cpp2ILInjected.Token(Token = "0x6000240")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCA2FC", Offset = "0x1CCA2FC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalBase), Member = "IsErrorHandled", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonContract),
			typeof(object),
			typeof(IJsonLineInfo),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void OnError(ErrorEventArgs e)
		{
			throw null;
		}

		// Token: 0x040000E0 RID: 224
		[global::Cpp2ILInjected.Token(Token = "0x40000EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal TypeNameHandling _typeNameHandling;

		// Token: 0x040000E1 RID: 225
		[global::Cpp2ILInjected.Token(Token = "0x40000F0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		internal FormatterAssemblyStyle _typeNameAssemblyFormat;

		// Token: 0x040000E2 RID: 226
		[global::Cpp2ILInjected.Token(Token = "0x40000F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal PreserveReferencesHandling _preserveReferencesHandling;

		// Token: 0x040000E3 RID: 227
		[global::Cpp2ILInjected.Token(Token = "0x40000F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		internal ReferenceLoopHandling _referenceLoopHandling;

		// Token: 0x040000E4 RID: 228
		[global::Cpp2ILInjected.Token(Token = "0x40000F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal MissingMemberHandling _missingMemberHandling;

		// Token: 0x040000E5 RID: 229
		[global::Cpp2ILInjected.Token(Token = "0x40000F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		internal ObjectCreationHandling _objectCreationHandling;

		// Token: 0x040000E6 RID: 230
		[global::Cpp2ILInjected.Token(Token = "0x40000F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal NullValueHandling _nullValueHandling;

		// Token: 0x040000E7 RID: 231
		[global::Cpp2ILInjected.Token(Token = "0x40000F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		internal DefaultValueHandling _defaultValueHandling;

		// Token: 0x040000E8 RID: 232
		[global::Cpp2ILInjected.Token(Token = "0x40000F7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal ConstructorHandling _constructorHandling;

		// Token: 0x040000E9 RID: 233
		[global::Cpp2ILInjected.Token(Token = "0x40000F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		internal MetadataPropertyHandling _metadataPropertyHandling;

		// Token: 0x040000EA RID: 234
		[global::Cpp2ILInjected.Token(Token = "0x40000F9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal JsonConverterCollection _converters;

		// Token: 0x040000EB RID: 235
		[global::Cpp2ILInjected.Token(Token = "0x40000FA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal IContractResolver _contractResolver;

		// Token: 0x040000EC RID: 236
		[global::Cpp2ILInjected.Token(Token = "0x40000FB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		internal ITraceWriter _traceWriter;

		// Token: 0x040000ED RID: 237
		[global::Cpp2ILInjected.Token(Token = "0x40000FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		internal IEqualityComparer _equalityComparer;

		// Token: 0x040000EE RID: 238
		[global::Cpp2ILInjected.Token(Token = "0x40000FD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		internal SerializationBinder _binder;

		// Token: 0x040000EF RID: 239
		[global::Cpp2ILInjected.Token(Token = "0x40000FE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		internal StreamingContext _context;

		// Token: 0x040000F0 RID: 240
		[global::Cpp2ILInjected.Token(Token = "0x40000FF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private IReferenceResolver _referenceResolver;

		// Token: 0x040000F1 RID: 241
		[global::Cpp2ILInjected.Token(Token = "0x4000100")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private Formatting? _formatting;

		// Token: 0x040000F2 RID: 242
		[global::Cpp2ILInjected.Token(Token = "0x4000101")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private DateFormatHandling? _dateFormatHandling;

		// Token: 0x040000F3 RID: 243
		[global::Cpp2ILInjected.Token(Token = "0x4000102")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private DateTimeZoneHandling? _dateTimeZoneHandling;

		// Token: 0x040000F4 RID: 244
		[global::Cpp2ILInjected.Token(Token = "0x4000103")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private DateParseHandling? _dateParseHandling;

		// Token: 0x040000F5 RID: 245
		[global::Cpp2ILInjected.Token(Token = "0x4000104")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private FloatFormatHandling? _floatFormatHandling;

		// Token: 0x040000F6 RID: 246
		[global::Cpp2ILInjected.Token(Token = "0x4000105")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private FloatParseHandling? _floatParseHandling;

		// Token: 0x040000F7 RID: 247
		[global::Cpp2ILInjected.Token(Token = "0x4000106")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private StringEscapeHandling? _stringEscapeHandling;

		// Token: 0x040000F8 RID: 248
		[global::Cpp2ILInjected.Token(Token = "0x4000107")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private CultureInfo _culture;

		// Token: 0x040000F9 RID: 249
		[global::Cpp2ILInjected.Token(Token = "0x4000108")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private int? _maxDepth;

		// Token: 0x040000FA RID: 250
		[global::Cpp2ILInjected.Token(Token = "0x4000109")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		private bool _maxDepthSet;

		// Token: 0x040000FB RID: 251
		[global::Cpp2ILInjected.Token(Token = "0x400010A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC1")]
		private bool? _checkAdditionalContent;

		// Token: 0x040000FC RID: 252
		[global::Cpp2ILInjected.Token(Token = "0x400010B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		private string _dateFormatString;

		// Token: 0x040000FD RID: 253
		[global::Cpp2ILInjected.Token(Token = "0x400010C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		private bool _dateFormatStringSet;

		// Token: 0x040000FE RID: 254
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400010D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		private EventHandler<ErrorEventArgs> Error;
	}
}
