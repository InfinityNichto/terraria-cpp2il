using System;
using System.Collections;
using System.Globalization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000085 RID: 133
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000AE")]
	internal class JsonSerializerProxy : JsonSerializer
	{
		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060005F2 RID: 1522 RVA: 0x000031F1 File Offset: 0x000013F1
		// (remove) Token: 0x060005F3 RID: 1523 RVA: 0x000031F4 File Offset: 0x000013F4
		[global::Cpp2ILInjected.Token(Token = "0x14000004")]
		public override event EventHandler<ErrorEventArgs> Error
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000664")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D01370", Offset = "0x1D01370", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			add
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000665")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D01380", Offset = "0x1D01380", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060005F4 RID: 1524 RVA: 0x000031F7 File Offset: 0x000013F7
		// (set) Token: 0x060005F5 RID: 1525 RVA: 0x000031FA File Offset: 0x000013FA
		[global::Cpp2ILInjected.Token(Token = "0x1700012C")]
		public override IReferenceResolver ReferenceResolver
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000666")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D01390", Offset = "0x1D01390", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000667")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D013A0", Offset = "0x1D013A0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060005F6 RID: 1526 RVA: 0x000031FD File Offset: 0x000013FD
		// (set) Token: 0x060005F7 RID: 1527 RVA: 0x00003200 File Offset: 0x00001400
		[global::Cpp2ILInjected.Token(Token = "0x1700012D")]
		public override ITraceWriter TraceWriter
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000668")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D013B0", Offset = "0x1D013B0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000669")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D013C0", Offset = "0x1D013C0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060005F8 RID: 1528 RVA: 0x00003203 File Offset: 0x00001403
		// (set) Token: 0x060005F9 RID: 1529 RVA: 0x00003206 File Offset: 0x00001406
		[global::Cpp2ILInjected.Token(Token = "0x1700012E")]
		public override IEqualityComparer EqualityComparer
		{
			[global::Cpp2ILInjected.Token(Token = "0x600066A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D013D0", Offset = "0x1D013D0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600066B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D013E0", Offset = "0x1D013E0", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060005FA RID: 1530 RVA: 0x00003209 File Offset: 0x00001409
		[global::Cpp2ILInjected.Token(Token = "0x1700012F")]
		public override JsonConverterCollection Converters
		{
			[global::Cpp2ILInjected.Token(Token = "0x600066C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D013F4", Offset = "0x1D013F4", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x0000320C File Offset: 0x0000140C
		// (set) Token: 0x060005FC RID: 1532 RVA: 0x0000320F File Offset: 0x0000140F
		[global::Cpp2ILInjected.Token(Token = "0x17000130")]
		public override DefaultValueHandling DefaultValueHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x600066D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D01408", Offset = "0x1D01408", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600066E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0141C", Offset = "0x1D0141C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060005FD RID: 1533 RVA: 0x00003212 File Offset: 0x00001412
		// (set) Token: 0x060005FE RID: 1534 RVA: 0x00003215 File Offset: 0x00001415
		[global::Cpp2ILInjected.Token(Token = "0x17000131")]
		public override IContractResolver ContractResolver
		{
			[global::Cpp2ILInjected.Token(Token = "0x600066F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D01430", Offset = "0x1D01430", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000670")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D01444", Offset = "0x1D01444", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060005FF RID: 1535 RVA: 0x00003218 File Offset: 0x00001418
		// (set) Token: 0x06000600 RID: 1536 RVA: 0x0000321B File Offset: 0x0000141B
		[global::Cpp2ILInjected.Token(Token = "0x17000132")]
		public override MissingMemberHandling MissingMemberHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000671")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D01458", Offset = "0x1D01458", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000672")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0146C", Offset = "0x1D0146C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000601 RID: 1537 RVA: 0x0000321E File Offset: 0x0000141E
		// (set) Token: 0x06000602 RID: 1538 RVA: 0x00003221 File Offset: 0x00001421
		[global::Cpp2ILInjected.Token(Token = "0x17000133")]
		public override NullValueHandling NullValueHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000673")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D01480", Offset = "0x1D01480", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000674")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D01494", Offset = "0x1D01494", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x00003224 File Offset: 0x00001424
		// (set) Token: 0x06000604 RID: 1540 RVA: 0x00003227 File Offset: 0x00001427
		[global::Cpp2ILInjected.Token(Token = "0x17000134")]
		public override ObjectCreationHandling ObjectCreationHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000675")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D014A8", Offset = "0x1D014A8", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000676")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D014BC", Offset = "0x1D014BC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000605 RID: 1541 RVA: 0x0000322A File Offset: 0x0000142A
		// (set) Token: 0x06000606 RID: 1542 RVA: 0x0000322D File Offset: 0x0000142D
		[global::Cpp2ILInjected.Token(Token = "0x17000135")]
		public override ReferenceLoopHandling ReferenceLoopHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000677")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D014D0", Offset = "0x1D014D0", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000678")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D014E4", Offset = "0x1D014E4", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x00003230 File Offset: 0x00001430
		// (set) Token: 0x06000608 RID: 1544 RVA: 0x00003233 File Offset: 0x00001433
		[global::Cpp2ILInjected.Token(Token = "0x17000136")]
		public override PreserveReferencesHandling PreserveReferencesHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000679")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D014F8", Offset = "0x1D014F8", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600067A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0150C", Offset = "0x1D0150C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000609 RID: 1545 RVA: 0x00003236 File Offset: 0x00001436
		// (set) Token: 0x0600060A RID: 1546 RVA: 0x00003239 File Offset: 0x00001439
		[global::Cpp2ILInjected.Token(Token = "0x17000137")]
		public override TypeNameHandling TypeNameHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x600067B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D01520", Offset = "0x1D01520", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600067C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D01534", Offset = "0x1D01534", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600060B RID: 1547 RVA: 0x0000323C File Offset: 0x0000143C
		// (set) Token: 0x0600060C RID: 1548 RVA: 0x0000323F File Offset: 0x0000143F
		[global::Cpp2ILInjected.Token(Token = "0x17000138")]
		public override MetadataPropertyHandling MetadataPropertyHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x600067D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D01548", Offset = "0x1D01548", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600067E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0155C", Offset = "0x1D0155C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600060D RID: 1549 RVA: 0x00003242 File Offset: 0x00001442
		// (set) Token: 0x0600060E RID: 1550 RVA: 0x00003245 File Offset: 0x00001445
		[global::Cpp2ILInjected.Token(Token = "0x17000139")]
		public override FormatterAssemblyStyle TypeNameAssemblyFormat
		{
			[global::Cpp2ILInjected.Token(Token = "0x600067F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D01570", Offset = "0x1D01570", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000680")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D01584", Offset = "0x1D01584", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600060F RID: 1551 RVA: 0x00003248 File Offset: 0x00001448
		// (set) Token: 0x06000610 RID: 1552 RVA: 0x0000324B File Offset: 0x0000144B
		[global::Cpp2ILInjected.Token(Token = "0x1700013A")]
		public override ConstructorHandling ConstructorHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000681")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D01598", Offset = "0x1D01598", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000682")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D015AC", Offset = "0x1D015AC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000611 RID: 1553 RVA: 0x0000324E File Offset: 0x0000144E
		// (set) Token: 0x06000612 RID: 1554 RVA: 0x00003251 File Offset: 0x00001451
		[global::Cpp2ILInjected.Token(Token = "0x1700013B")]
		public override SerializationBinder Binder
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000683")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D015C0", Offset = "0x1D015C0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000684")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D015D0", Offset = "0x1D015D0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000613 RID: 1555 RVA: 0x00003254 File Offset: 0x00001454
		// (set) Token: 0x06000614 RID: 1556 RVA: 0x00003257 File Offset: 0x00001457
		[global::Cpp2ILInjected.Token(Token = "0x1700013C")]
		public override StreamingContext Context
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000685")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D015E0", Offset = "0x1D015E0", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000686")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D015F4", Offset = "0x1D015F4", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000615 RID: 1557 RVA: 0x0000325A File Offset: 0x0000145A
		// (set) Token: 0x06000616 RID: 1558 RVA: 0x0000325D File Offset: 0x0000145D
		[global::Cpp2ILInjected.Token(Token = "0x1700013D")]
		public override Formatting Formatting
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000687")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D01608", Offset = "0x1D01608", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000688")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0161C", Offset = "0x1D0161C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000617 RID: 1559 RVA: 0x00003260 File Offset: 0x00001460
		// (set) Token: 0x06000618 RID: 1560 RVA: 0x00003263 File Offset: 0x00001463
		[global::Cpp2ILInjected.Token(Token = "0x1700013E")]
		public override DateFormatHandling DateFormatHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000689")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D01630", Offset = "0x1D01630", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600068A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D01644", Offset = "0x1D01644", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000619 RID: 1561 RVA: 0x00003266 File Offset: 0x00001466
		// (set) Token: 0x0600061A RID: 1562 RVA: 0x00003269 File Offset: 0x00001469
		[global::Cpp2ILInjected.Token(Token = "0x1700013F")]
		public override DateTimeZoneHandling DateTimeZoneHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x600068B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D01658", Offset = "0x1D01658", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600068C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0166C", Offset = "0x1D0166C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x0000326C File Offset: 0x0000146C
		// (set) Token: 0x0600061C RID: 1564 RVA: 0x0000326F File Offset: 0x0000146F
		[global::Cpp2ILInjected.Token(Token = "0x17000140")]
		public override DateParseHandling DateParseHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x600068D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D01680", Offset = "0x1D01680", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600068E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D01694", Offset = "0x1D01694", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x0600061D RID: 1565 RVA: 0x00003272 File Offset: 0x00001472
		// (set) Token: 0x0600061E RID: 1566 RVA: 0x00003275 File Offset: 0x00001475
		[global::Cpp2ILInjected.Token(Token = "0x17000141")]
		public override FloatFormatHandling FloatFormatHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x600068F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D016A8", Offset = "0x1D016A8", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000690")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D016BC", Offset = "0x1D016BC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600061F RID: 1567 RVA: 0x00003278 File Offset: 0x00001478
		// (set) Token: 0x06000620 RID: 1568 RVA: 0x0000327B File Offset: 0x0000147B
		[global::Cpp2ILInjected.Token(Token = "0x17000142")]
		public override FloatParseHandling FloatParseHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000691")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D016D0", Offset = "0x1D016D0", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000692")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D016E4", Offset = "0x1D016E4", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000621 RID: 1569 RVA: 0x0000327E File Offset: 0x0000147E
		// (set) Token: 0x06000622 RID: 1570 RVA: 0x00003281 File Offset: 0x00001481
		[global::Cpp2ILInjected.Token(Token = "0x17000143")]
		public override StringEscapeHandling StringEscapeHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000693")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D016F8", Offset = "0x1D016F8", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000694")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0170C", Offset = "0x1D0170C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000623 RID: 1571 RVA: 0x00003284 File Offset: 0x00001484
		// (set) Token: 0x06000624 RID: 1572 RVA: 0x00003287 File Offset: 0x00001487
		[global::Cpp2ILInjected.Token(Token = "0x17000144")]
		public override string DateFormatString
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000695")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D01720", Offset = "0x1D01720", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000696")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D01734", Offset = "0x1D01734", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000625 RID: 1573 RVA: 0x0000328A File Offset: 0x0000148A
		// (set) Token: 0x06000626 RID: 1574 RVA: 0x0000328D File Offset: 0x0000148D
		[global::Cpp2ILInjected.Token(Token = "0x17000145")]
		public override CultureInfo Culture
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000697")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D01748", Offset = "0x1D01748", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000698")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0175C", Offset = "0x1D0175C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000627 RID: 1575 RVA: 0x00003290 File Offset: 0x00001490
		// (set) Token: 0x06000628 RID: 1576 RVA: 0x00003293 File Offset: 0x00001493
		[global::Cpp2ILInjected.Token(Token = "0x17000146")]
		public override int? MaxDepth
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000699")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D01770", Offset = "0x1D01770", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600069A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D01784", Offset = "0x1D01784", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000629 RID: 1577 RVA: 0x00003296 File Offset: 0x00001496
		// (set) Token: 0x0600062A RID: 1578 RVA: 0x00003299 File Offset: 0x00001499
		[global::Cpp2ILInjected.Token(Token = "0x17000147")]
		public override bool CheckAdditionalContent
		{
			[global::Cpp2ILInjected.Token(Token = "0x600069B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D01798", Offset = "0x1D01798", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600069C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D017AC", Offset = "0x1D017AC", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x0000329C File Offset: 0x0000149C
		[global::Cpp2ILInjected.Token(Token = "0x600069D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D017C4", Offset = "0x1D017C4", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultReferenceResolver), Member = "GetMappings", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(BidirectionalDictionary<string, object>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal JsonSerializerInternalBase GetInternalSerializer()
		{
			throw null;
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x0000329F File Offset: 0x0000149F
		[global::Cpp2ILInjected.Token(Token = "0x600069E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D017E0", Offset = "0x1D017E0", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "GetInternalSerializer", ReturnType = typeof(JsonSerializerProxy))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public JsonSerializerProxy(JsonSerializerInternalReader serializerReader)
		{
			throw null;
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x000032A2 File Offset: 0x000014A2
		[global::Cpp2ILInjected.Token(Token = "0x600069F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CFC6BC", Offset = "0x1CFC6BC", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "GetInternalSerializer", ReturnType = typeof(JsonSerializerProxy))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public JsonSerializerProxy(JsonSerializerInternalWriter serializerWriter)
		{
			throw null;
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x000032A5 File Offset: 0x000014A5
		[global::Cpp2ILInjected.Token(Token = "0x60006A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D01854", Offset = "0x1D01854", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type)
		}, ReturnType = typeof(object))]
		internal override object DeserializeInternal(JsonReader reader, Type objectType)
		{
			throw null;
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x000032A8 File Offset: 0x000014A8
		[global::Cpp2ILInjected.Token(Token = "0x60006A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D01878", Offset = "0x1D01878", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "Populate", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "Populate", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(object)
		}, ReturnType = typeof(void))]
		internal override void PopulateInternal(JsonReader reader, object target)
		{
			throw null;
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x000032AB File Offset: 0x000014AB
		[global::Cpp2ILInjected.Token(Token = "0x60006A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D01898", Offset = "0x1D01898", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object)
		}, ReturnType = typeof(void))]
		internal override void SerializeInternal(JsonWriter jsonWriter, object value, Type rootType)
		{
			throw null;
		}

		// Token: 0x04000265 RID: 613
		[global::Cpp2ILInjected.Token(Token = "0x40002D4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		private readonly JsonSerializerInternalReader _serializerReader;

		// Token: 0x04000266 RID: 614
		[global::Cpp2ILInjected.Token(Token = "0x40002D5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		private readonly JsonSerializerInternalWriter _serializerWriter;

		// Token: 0x04000267 RID: 615
		[global::Cpp2ILInjected.Token(Token = "0x40002D6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		private readonly JsonSerializer _serializer;
	}
}
