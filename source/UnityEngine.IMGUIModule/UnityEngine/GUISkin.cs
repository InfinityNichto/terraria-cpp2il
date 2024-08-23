using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000014 RID: 20
	[AssetFileNameExtension("guiskin", new string[] { })]
	[RequiredByNativeCode]
	[ExecuteInEditMode]
	[global::Cpp2ILInjected.Token(Token = "0x2000017")]
	[Serializable]
	public sealed class GUISkin : ScriptableObject
	{
		// Token: 0x0600009C RID: 156 RVA: 0x000021BE File Offset: 0x000003BE
		[global::Cpp2ILInjected.Token(Token = "0x60000A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9C368", Offset = "0x1F9C368", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public GUISkin()
		{
			throw null;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000021C1 File Offset: 0x000003C1
		[global::Cpp2ILInjected.Token(Token = "0x60000A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9C41C", Offset = "0x1F9C41C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void OnEnable()
		{
			throw null;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000021C4 File Offset: 0x000003C4
		[global::Cpp2ILInjected.Token(Token = "0x60000A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9C49C", Offset = "0x1F9C49C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static void CleanupRoots()
		{
			throw null;
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600009F RID: 159 RVA: 0x000021C7 File Offset: 0x000003C7
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x000021CA File Offset: 0x000003CA
		[global::Cpp2ILInjected.Token(Token = "0x17000029")]
		public Font font
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000A3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C4E8", Offset = "0x1F9C4E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000A4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C4F0", Offset = "0x1F9C4F0", Length = "0xE8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TestInputManager", Member = "OnGUI", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISkin), Member = "Apply", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x000021CD File Offset: 0x000003CD
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x000021D0 File Offset: 0x000003D0
		[global::Cpp2ILInjected.Token(Token = "0x1700002A")]
		public GUIStyle box
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000A5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C614", Offset = "0x1F9C614", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SimpleProfiler", Member = "OnGUI", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000A6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C61C", Offset = "0x1F9C61C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISkin), Member = "Apply", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x000021D3 File Offset: 0x000003D3
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x000021D6 File Offset: 0x000003D6
		[global::Cpp2ILInjected.Token(Token = "0x1700002B")]
		public GUIStyle label
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000A7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F96330", Offset = "0x1F96330", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000A8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C624", Offset = "0x1F9C624", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISkin), Member = "Apply", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x000021D9 File Offset: 0x000003D9
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x000021DC File Offset: 0x000003DC
		[global::Cpp2ILInjected.Token(Token = "0x1700002C")]
		public GUIStyle textField
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000A9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C62C", Offset = "0x1F9C62C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000AA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C634", Offset = "0x1F9C634", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISkin), Member = "Apply", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x000021DF File Offset: 0x000003DF
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x000021E2 File Offset: 0x000003E2
		[global::Cpp2ILInjected.Token(Token = "0x1700002D")]
		public GUIStyle textArea
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000AB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C63C", Offset = "0x1F9C63C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C644", Offset = "0x1F9C644", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISkin), Member = "Apply", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x000021E5 File Offset: 0x000003E5
		// (set) Token: 0x060000AA RID: 170 RVA: 0x000021E8 File Offset: 0x000003E8
		[global::Cpp2ILInjected.Token(Token = "0x1700002E")]
		public GUIStyle button
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000AD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F967C8", Offset = "0x1F967C8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000AE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C64C", Offset = "0x1F9C64C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISkin), Member = "Apply", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000AB RID: 171 RVA: 0x000021EB File Offset: 0x000003EB
		// (set) Token: 0x060000AC RID: 172 RVA: 0x000021EE File Offset: 0x000003EE
		[global::Cpp2ILInjected.Token(Token = "0x1700002F")]
		public GUIStyle toggle
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000AF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C654", Offset = "0x1F9C654", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000B0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C65C", Offset = "0x1F9C65C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISkin), Member = "Apply", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000AD RID: 173 RVA: 0x000021F1 File Offset: 0x000003F1
		// (set) Token: 0x060000AE RID: 174 RVA: 0x000021F4 File Offset: 0x000003F4
		[global::Cpp2ILInjected.Token(Token = "0x17000030")]
		public GUIStyle window
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000B1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C664", Offset = "0x1F9C664", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000B2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C66C", Offset = "0x1F9C66C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISkin), Member = "Apply", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000AF RID: 175 RVA: 0x000021F7 File Offset: 0x000003F7
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x000021FA File Offset: 0x000003FA
		[global::Cpp2ILInjected.Token(Token = "0x17000031")]
		public GUIStyle horizontalSlider
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000B3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C674", Offset = "0x1F9C674", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000B4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C67C", Offset = "0x1F9C67C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISkin), Member = "Apply", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x000021FD File Offset: 0x000003FD
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x00002200 File Offset: 0x00000400
		[global::Cpp2ILInjected.Token(Token = "0x17000032")]
		public GUIStyle horizontalSliderThumb
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000B5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C684", Offset = "0x1F9C684", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000B6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C68C", Offset = "0x1F9C68C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISkin), Member = "Apply", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00002203 File Offset: 0x00000403
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x00002206 File Offset: 0x00000406
		[global::Cpp2ILInjected.Token(Token = "0x17000033")]
		internal GUIStyle horizontalSliderThumbExtent
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000B7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C694", Offset = "0x1F9C694", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000B8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C69C", Offset = "0x1F9C69C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISkin), Member = "Apply", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00002209 File Offset: 0x00000409
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x0000220C File Offset: 0x0000040C
		[global::Cpp2ILInjected.Token(Token = "0x17000034")]
		internal GUIStyle sliderMixed
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000B9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C6A4", Offset = "0x1F9C6A4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000BA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C6AC", Offset = "0x1F9C6AC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISkin), Member = "Apply", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x0000220F File Offset: 0x0000040F
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x00002212 File Offset: 0x00000412
		[global::Cpp2ILInjected.Token(Token = "0x17000035")]
		public GUIStyle verticalSlider
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000BB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C6B4", Offset = "0x1F9C6B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000BC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C6BC", Offset = "0x1F9C6BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISkin), Member = "Apply", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00002215 File Offset: 0x00000415
		// (set) Token: 0x060000BA RID: 186 RVA: 0x00002218 File Offset: 0x00000418
		[global::Cpp2ILInjected.Token(Token = "0x17000036")]
		public GUIStyle verticalSliderThumb
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000BD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C6C4", Offset = "0x1F9C6C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000BE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C6CC", Offset = "0x1F9C6CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISkin), Member = "Apply", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000BB RID: 187 RVA: 0x0000221B File Offset: 0x0000041B
		// (set) Token: 0x060000BC RID: 188 RVA: 0x0000221E File Offset: 0x0000041E
		[global::Cpp2ILInjected.Token(Token = "0x17000037")]
		internal GUIStyle verticalSliderThumbExtent
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000BF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C6D4", Offset = "0x1F9C6D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000C0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C6DC", Offset = "0x1F9C6DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISkin), Member = "Apply", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00002221 File Offset: 0x00000421
		// (set) Token: 0x060000BE RID: 190 RVA: 0x00002224 File Offset: 0x00000424
		[global::Cpp2ILInjected.Token(Token = "0x17000038")]
		public GUIStyle horizontalScrollbar
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000C1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C6E4", Offset = "0x1F9C6E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000C2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C6EC", Offset = "0x1F9C6EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISkin), Member = "Apply", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00002227 File Offset: 0x00000427
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x0000222A File Offset: 0x0000042A
		[global::Cpp2ILInjected.Token(Token = "0x17000039")]
		public GUIStyle horizontalScrollbarThumb
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000C3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C6F4", Offset = "0x1F9C6F4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000C4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C6FC", Offset = "0x1F9C6FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISkin), Member = "Apply", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x0000222D File Offset: 0x0000042D
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x00002230 File Offset: 0x00000430
		[global::Cpp2ILInjected.Token(Token = "0x1700003A")]
		public GUIStyle horizontalScrollbarLeftButton
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000C5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C704", Offset = "0x1F9C704", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000C6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C70C", Offset = "0x1F9C70C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISkin), Member = "Apply", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00002233 File Offset: 0x00000433
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x00002236 File Offset: 0x00000436
		[global::Cpp2ILInjected.Token(Token = "0x1700003B")]
		public GUIStyle horizontalScrollbarRightButton
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000C7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C714", Offset = "0x1F9C714", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000C8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C71C", Offset = "0x1F9C71C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISkin), Member = "Apply", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00002239 File Offset: 0x00000439
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x0000223C File Offset: 0x0000043C
		[global::Cpp2ILInjected.Token(Token = "0x1700003C")]
		public GUIStyle verticalScrollbar
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000C9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C724", Offset = "0x1F9C724", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000CA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C72C", Offset = "0x1F9C72C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISkin), Member = "Apply", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x0000223F File Offset: 0x0000043F
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x00002242 File Offset: 0x00000442
		[global::Cpp2ILInjected.Token(Token = "0x1700003D")]
		public GUIStyle verticalScrollbarThumb
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000CB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C734", Offset = "0x1F9C734", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000CC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C73C", Offset = "0x1F9C73C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISkin), Member = "Apply", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00002245 File Offset: 0x00000445
		// (set) Token: 0x060000CA RID: 202 RVA: 0x00002248 File Offset: 0x00000448
		[global::Cpp2ILInjected.Token(Token = "0x1700003E")]
		public GUIStyle verticalScrollbarUpButton
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000CD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C744", Offset = "0x1F9C744", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000CE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C74C", Offset = "0x1F9C74C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISkin), Member = "Apply", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000CB RID: 203 RVA: 0x0000224B File Offset: 0x0000044B
		// (set) Token: 0x060000CC RID: 204 RVA: 0x0000224E File Offset: 0x0000044E
		[global::Cpp2ILInjected.Token(Token = "0x1700003F")]
		public GUIStyle verticalScrollbarDownButton
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000CF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C754", Offset = "0x1F9C754", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000D0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C75C", Offset = "0x1F9C75C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISkin), Member = "Apply", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00002251 File Offset: 0x00000451
		// (set) Token: 0x060000CE RID: 206 RVA: 0x00002254 File Offset: 0x00000454
		[global::Cpp2ILInjected.Token(Token = "0x17000040")]
		public GUIStyle scrollView
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000D1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C764", Offset = "0x1F9C764", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000D2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C76C", Offset = "0x1F9C76C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISkin), Member = "Apply", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00002257 File Offset: 0x00000457
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x0000225A File Offset: 0x0000045A
		[global::Cpp2ILInjected.Token(Token = "0x17000041")]
		public GUIStyle[] customStyles
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000D3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C774", Offset = "0x1F9C774", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000D4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C77C", Offset = "0x1F9C77C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISkin), Member = "Apply", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x0000225D File Offset: 0x0000045D
		[global::Cpp2ILInjected.Token(Token = "0x17000042")]
		public GUISettings settings
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000D5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C784", Offset = "0x1F9C784", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00002260 File Offset: 0x00000460
		[global::Cpp2ILInjected.Token(Token = "0x17000043")]
		internal static GUIStyle error
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000D6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C78C", Offset = "0x1F9C78C", Length = "0xE4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISkin), Member = "GetStyle", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(GUIStyle))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStyle), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002263 File Offset: 0x00000463
		[global::Cpp2ILInjected.Token(Token = "0x60000D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9C420", Offset = "0x1F9C420", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 25)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal void Apply()
		{
			throw null;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002266 File Offset: 0x00000466
		[global::Cpp2ILInjected.Token(Token = "0x60000D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9C940", Offset = "0x1F9C940", Length = "0xD28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISkin), Member = "Apply", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISkin), Member = "FindStyle", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(GUIStyle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISkin), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStyle), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", MemberParameters = new object[] { typeof(IEqualityComparer<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISkin), Member = "get_error", ReturnType = typeof(GUIStyle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStyle), Member = "get_normal", ReturnType = typeof(GUIStyleState))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStyleState), Member = "set_textColor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 83)]
		private void BuildStyleCache()
		{
			throw null;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00002269 File Offset: 0x00000469
		[global::Cpp2ILInjected.Token(Token = "0x60000D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9D75C", Offset = "0x1F9D75C", Length = "0x280")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISkin), Member = "FindStyle", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(GUIStyle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISkin), Member = "get_error", ReturnType = typeof(GUIStyle))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public GUIStyle GetStyle(string styleName)
		{
			throw null;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000226C File Offset: 0x0000046C
		[global::Cpp2ILInjected.Token(Token = "0x60000DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9D9DC", Offset = "0x1F9D9DC", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISkin), Member = "GetStyle", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(GUIStyle))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public GUIStyle FindStyle(string styleName)
		{
			throw null;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000226F File Offset: 0x0000046F
		[global::Cpp2ILInjected.Token(Token = "0x60000DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F96114", Offset = "0x1F96114", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUI), Member = "DoSetSkin", MemberParameters = new object[] { typeof(GUISkin) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal void MakeCurrent()
		{
			throw null;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002272 File Offset: 0x00000472
		[global::Cpp2ILInjected.Token(Token = "0x60000DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9DA5C", Offset = "0x1F9DA5C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Values", ReturnType = "ValueCollection<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.ValueCollection), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public IEnumerator GetEnumerator()
		{
			throw null;
		}

		// Token: 0x04000082 RID: 130
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000089")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Font m_Font;

		// Token: 0x04000083 RID: 131
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400008A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private GUIStyle m_box;

		// Token: 0x04000084 RID: 132
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400008B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private GUIStyle m_button;

		// Token: 0x04000085 RID: 133
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400008C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private GUIStyle m_toggle;

		// Token: 0x04000086 RID: 134
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400008D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private GUIStyle m_label;

		// Token: 0x04000087 RID: 135
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400008E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private GUIStyle m_textField;

		// Token: 0x04000088 RID: 136
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400008F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private GUIStyle m_textArea;

		// Token: 0x04000089 RID: 137
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000090")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private GUIStyle m_window;

		// Token: 0x0400008A RID: 138
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000091")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private GUIStyle m_horizontalSlider;

		// Token: 0x0400008B RID: 139
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000092")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private GUIStyle m_horizontalSliderThumb;

		// Token: 0x0400008C RID: 140
		[global::Cpp2ILInjected.Token(Token = "0x4000093")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		[NonSerialized]
		private GUIStyle m_horizontalSliderThumbExtent;

		// Token: 0x0400008D RID: 141
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000094")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private GUIStyle m_verticalSlider;

		// Token: 0x0400008E RID: 142
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000095")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private GUIStyle m_verticalSliderThumb;

		// Token: 0x0400008F RID: 143
		[global::Cpp2ILInjected.Token(Token = "0x4000096")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		[NonSerialized]
		private GUIStyle m_verticalSliderThumbExtent;

		// Token: 0x04000090 RID: 144
		[global::Cpp2ILInjected.Token(Token = "0x4000097")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		[NonSerialized]
		private GUIStyle m_SliderMixed;

		// Token: 0x04000091 RID: 145
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000098")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private GUIStyle m_horizontalScrollbar;

		// Token: 0x04000092 RID: 146
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000099")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private GUIStyle m_horizontalScrollbarThumb;

		// Token: 0x04000093 RID: 147
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400009A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private GUIStyle m_horizontalScrollbarLeftButton;

		// Token: 0x04000094 RID: 148
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400009B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private GUIStyle m_horizontalScrollbarRightButton;

		// Token: 0x04000095 RID: 149
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400009C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private GUIStyle m_verticalScrollbar;

		// Token: 0x04000096 RID: 150
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400009D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private GUIStyle m_verticalScrollbarThumb;

		// Token: 0x04000097 RID: 151
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400009E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		private GUIStyle m_verticalScrollbarUpButton;

		// Token: 0x04000098 RID: 152
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400009F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		private GUIStyle m_verticalScrollbarDownButton;

		// Token: 0x04000099 RID: 153
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40000A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		private GUIStyle m_ScrollView;

		// Token: 0x0400009A RID: 154
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40000A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		internal GUIStyle[] m_CustomStyles;

		// Token: 0x0400009B RID: 155
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40000A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		private GUISettings m_Settings;

		// Token: 0x0400009C RID: 156
		[global::Cpp2ILInjected.Token(Token = "0x40000A3")]
		internal static GUIStyle ms_Error;

		// Token: 0x0400009D RID: 157
		[global::Cpp2ILInjected.Token(Token = "0x40000A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		private Dictionary<string, GUIStyle> m_Styles;

		// Token: 0x0400009E RID: 158
		[global::Cpp2ILInjected.Token(Token = "0x40000A5")]
		internal static GUISkin.SkinChangedDelegate m_SkinChanged;

		// Token: 0x0400009F RID: 159
		[global::Cpp2ILInjected.Token(Token = "0x40000A6")]
		internal static GUISkin current;

		// Token: 0x0200002B RID: 43
		// (Invoke) Token: 0x06000135 RID: 309
		[global::Cpp2ILInjected.Token(Token = "0x2000018")]
		internal delegate void SkinChangedDelegate();
	}
}
