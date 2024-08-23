using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000B9 RID: 185
	[global::Cpp2ILInjected.Token(Token = "0x20000FF")]
	public class QuaternionConverter : JsonConverter
	{
		// Token: 0x060008F7 RID: 2295 RVA: 0x00003ACD File Offset: 0x00001CCD
		[global::Cpp2ILInjected.Token(Token = "0x6000A2C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D274E4", Offset = "0x1D274E4", Length = "0x32C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Quaternion), Member = "Internal_ToEulerRad", MemberParameters = new object[] { typeof(Quaternion) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Quaternion), Member = "Internal_MakePositive", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			throw null;
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x00003AD0 File Offset: 0x00001CD0
		[global::Cpp2ILInjected.Token(Token = "0x6000A2D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D27810", Offset = "0x1D27810", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool CanConvert(Type objectType)
		{
			throw null;
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x00003AD3 File Offset: 0x00001CD3
		[global::Cpp2ILInjected.Token(Token = "0x6000A2E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D27894", Offset = "0x1D27894", Length = "0x5DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = "Load", MemberParameters = new object[] { typeof(JsonReader) }, ReturnType = typeof(JObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = "Properties", ReturnType = typeof(IEnumerable<JProperty>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Quaternion), Member = "Internal_FromEulerRad", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(Quaternion))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 37)]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			throw null;
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060008FA RID: 2298 RVA: 0x00003AD6 File Offset: 0x00001CD6
		[global::Cpp2ILInjected.Token(Token = "0x170001D0")]
		public override bool CanRead
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A2F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D27E70", Offset = "0x1D27E70", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x00003AD9 File Offset: 0x00001CD9
		[global::Cpp2ILInjected.Token(Token = "0x6000A30")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D27E78", Offset = "0x1D27E78", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConverter), Member = ".ctor", ReturnType = typeof(void))]
		public QuaternionConverter()
		{
			throw null;
		}

		// Token: 0x02000136 RID: 310
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000100")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000BAE RID: 2990 RVA: 0x00004286 File Offset: 0x00002486
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6000A31")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D27E80", Offset = "0x1D27E80", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06000BAF RID: 2991 RVA: 0x00004289 File Offset: 0x00002489
			[global::Cpp2ILInjected.Token(Token = "0x6000A32")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D27EDC", Offset = "0x1D27EDC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06000BB0 RID: 2992 RVA: 0x0000428C File Offset: 0x0000248C
			[global::Cpp2ILInjected.Token(Token = "0x6000A33")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D27EE4", Offset = "0x1D27EE4", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal bool <ReadJson>b__2_0(JProperty p)
			{
				throw null;
			}

			// Token: 0x06000BB1 RID: 2993 RVA: 0x0000428F File Offset: 0x0000248F
			[global::Cpp2ILInjected.Token(Token = "0x6000A34")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D27F30", Offset = "0x1D27F30", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal bool <ReadJson>b__2_1(JProperty p)
			{
				throw null;
			}

			// Token: 0x06000BB2 RID: 2994 RVA: 0x00004292 File Offset: 0x00002492
			[global::Cpp2ILInjected.Token(Token = "0x6000A35")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D27F7C", Offset = "0x1D27F7C", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal bool <ReadJson>b__2_2(JProperty p)
			{
				throw null;
			}

			// Token: 0x06000BB3 RID: 2995 RVA: 0x00004295 File Offset: 0x00002495
			[global::Cpp2ILInjected.Token(Token = "0x6000A36")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D27FC8", Offset = "0x1D27FC8", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal bool <ReadJson>b__2_3(JProperty p)
			{
				throw null;
			}

			// Token: 0x06000BB4 RID: 2996 RVA: 0x00004298 File Offset: 0x00002498
			[global::Cpp2ILInjected.Token(Token = "0x6000A37")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D28014", Offset = "0x1D28014", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal bool <ReadJson>b__2_4(JProperty p)
			{
				throw null;
			}

			// Token: 0x04000471 RID: 1137
			[global::Cpp2ILInjected.Token(Token = "0x40003F9")]
			public static readonly QuaternionConverter.<>c <>9;

			// Token: 0x04000472 RID: 1138
			[global::Cpp2ILInjected.Token(Token = "0x40003FA")]
			public static Func<JProperty, bool> <>9__2_0;

			// Token: 0x04000473 RID: 1139
			[global::Cpp2ILInjected.Token(Token = "0x40003FB")]
			public static Func<JProperty, bool> <>9__2_1;

			// Token: 0x04000474 RID: 1140
			[global::Cpp2ILInjected.Token(Token = "0x40003FC")]
			public static Func<JProperty, bool> <>9__2_2;

			// Token: 0x04000475 RID: 1141
			[global::Cpp2ILInjected.Token(Token = "0x40003FD")]
			public static Func<JProperty, bool> <>9__2_3;

			// Token: 0x04000476 RID: 1142
			[global::Cpp2ILInjected.Token(Token = "0x40003FE")]
			public static Func<JProperty, bool> <>9__2_4;
		}
	}
}
