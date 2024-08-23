using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000005 RID: 5
	[UsedByNativeCode]
	[NativeHeader("Modules/TextRendering/TextGenerator.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000005")]
	[StructLayout(0)]
	public sealed class TextGenerator : IDisposable
	{
		// Token: 0x06000004 RID: 4 RVA: 0x00002059 File Offset: 0x00000259
		[global::Cpp2ILInjected.Token(Token = "0x6000004")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA4678", Offset = "0x1FA4678", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "get_cachedInputTextGenerator", ReturnType = typeof(TextGenerator))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Text", Member = "get_cachedTextGenerator", ReturnType = typeof(TextGenerator))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Text", Member = "get_cachedTextGeneratorForLayout", ReturnType = typeof(TextGenerator))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public TextGenerator()
		{
			throw null;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000205C File Offset: 0x0000025C
		[global::Cpp2ILInjected.Token(Token = "0x6000005")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA4680", Offset = "0x1FA4680", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Text", Member = "get_cachedTextGenerator", ReturnType = typeof(TextGenerator))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<UIVertex>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<UICharInfo>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<UILineInfo>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public TextGenerator(int initialCapacity)
		{
			throw null;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000205F File Offset: 0x0000025F
		[global::Cpp2ILInjected.Token(Token = "0x6000006")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA47F4", Offset = "0x1FA47F4", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002062 File Offset: 0x00000262
		[global::Cpp2ILInjected.Token(Token = "0x6000007")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA4904", Offset = "0x1FA4904", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void System.IDisposable.Dispose()
		{
			throw null;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002065 File Offset: 0x00000265
		[global::Cpp2ILInjected.Token(Token = "0x17000001")]
		public int characterCountVisible
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000008")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA49E0", Offset = "0x1FA49E0", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "GetCharacterIndexFromPosition", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "LineDownCharacterPosition", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "GetLineEndPosition", MemberParameters = new object[]
			{
				typeof(TextGenerator),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "SetDrawRangeToContainCaretPosition", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002068 File Offset: 0x00000268
		[global::Cpp2ILInjected.Token(Token = "0x6000009")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA4A60", Offset = "0x1FA4A60", Length = "0x28C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextGenerator), Member = "PopulateAlways", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TextGenerationSettings)
		}, ReturnType = typeof(TextGenerationError))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogWarningFormat", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private TextGenerationSettings ValidatedSettings(TextGenerationSettings settings)
		{
			throw null;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000206B File Offset: 0x0000026B
		[global::Cpp2ILInjected.Token(Token = "0x600000A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA4D28", Offset = "0x1FA4D28", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Text", Member = "FontTextureChanged", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Text", Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public void Invalidate()
		{
			throw null;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000206E File Offset: 0x0000026E
		[global::Cpp2ILInjected.Token(Token = "0x600000B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA4D30", Offset = "0x1FA4D30", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void GetCharacters(List<UICharInfo> characters)
		{
			throw null;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002071 File Offset: 0x00000271
		[global::Cpp2ILInjected.Token(Token = "0x600000C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA4DB8", Offset = "0x1FA4DB8", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void GetLines(List<UILineInfo> lines)
		{
			throw null;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002074 File Offset: 0x00000274
		[global::Cpp2ILInjected.Token(Token = "0x600000D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA4E40", Offset = "0x1FA4E40", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void GetVertices(List<UIVertex> vertices)
		{
			throw null;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002077 File Offset: 0x00000277
		[global::Cpp2ILInjected.Token(Token = "0x600000E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA4EC8", Offset = "0x1FA4EC8", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "get_preferredWidth", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Text", Member = "get_preferredWidth", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "PopulateWithError", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TextGenerationSettings)
		}, ReturnType = typeof(TextGenerationError))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "get_rectExtents", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_width", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public float GetPreferredWidth(string str, TextGenerationSettings settings)
		{
			throw null;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000207A File Offset: 0x0000027A
		[global::Cpp2ILInjected.Token(Token = "0x600000F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA4FE4", Offset = "0x1FA4FE4", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "get_preferredHeight", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Text", Member = "get_preferredHeight", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "PopulateWithError", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TextGenerationSettings)
		}, ReturnType = typeof(TextGenerationError))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "get_rectExtents", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_height", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public float GetPreferredHeight(string str, TextGenerationSettings settings)
		{
			throw null;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000207D File Offset: 0x0000027D
		[global::Cpp2ILInjected.Token(Token = "0x6000010")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA5054", Offset = "0x1FA5054", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateLabel", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Text", Member = "OnPopulateMesh", MemberParameters = new object[] { "UnityEngine.UI.VertexHelper" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "PopulateWithError", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TextGenerationSettings)
		}, ReturnType = typeof(TextGenerationError))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogErrorFormat", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public bool PopulateWithErrors(string str, TextGenerationSettings settings, GameObject context)
		{
			throw null;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002080 File Offset: 0x00000280
		[global::Cpp2ILInjected.Token(Token = "0x6000011")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA4F3C", Offset = "0x1FA4F3C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "PopulateWithError", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TextGenerationSettings)
		}, ReturnType = typeof(TextGenerationError))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool Populate(string str, TextGenerationSettings settings)
		{
			throw null;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002083 File Offset: 0x00000283
		[global::Cpp2ILInjected.Token(Token = "0x6000012")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA51E4", Offset = "0x1FA51E4", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextGenerator), Member = "GetPreferredWidth", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TextGenerationSettings)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextGenerator), Member = "GetPreferredHeight", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TextGenerationSettings)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextGenerator), Member = "PopulateWithErrors", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TextGenerationSettings),
			typeof(GameObject)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextGenerator), Member = "Populate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TextGenerationSettings)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerationSettings), Member = "Equals", MemberParameters = new object[] { typeof(TextGenerationSettings) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "PopulateAlways", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TextGenerationSettings)
		}, ReturnType = typeof(TextGenerationError))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private TextGenerationError PopulateWithError(string str, TextGenerationSettings settings)
		{
			throw null;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002086 File Offset: 0x00000286
		[global::Cpp2ILInjected.Token(Token = "0x6000013")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA5274", Offset = "0x1FA5274", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextGenerator), Member = "PopulateWithError", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TextGenerationSettings)
		}, ReturnType = typeof(TextGenerationError))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "ValidatedSettings", MemberParameters = new object[] { typeof(TextGenerationSettings) }, ReturnType = typeof(TextGenerationSettings))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "Populate_Internal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Font),
			typeof(Color),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(FontStyle),
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(int),
			typeof(VerticalWrapMode),
			typeof(HorizontalWrapMode),
			typeof(bool),
			typeof(TextAnchor),
			typeof(Vector2),
			typeof(Vector2),
			typeof(bool),
			typeof(bool),
			typeof(ref TextGenerationError)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private TextGenerationError PopulateAlways(string str, TextGenerationSettings settings)
		{
			throw null;
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002089 File Offset: 0x00000289
		[global::Cpp2ILInjected.Token(Token = "0x17000002")]
		public IList<UIVertex> verts
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000014")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA5528", Offset = "0x1FA5528", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Text", Member = "OnPopulateMesh", MemberParameters = new object[] { "UnityEngine.UI.VertexHelper" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000015 RID: 21 RVA: 0x0000208C File Offset: 0x0000028C
		[global::Cpp2ILInjected.Token(Token = "0x17000003")]
		public IList<UICharInfo> characters
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000015")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA5584", Offset = "0x1FA5584", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "GetCharacterIndexFromPosition", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "LineUpCharacterPosition", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "LineDownCharacterPosition", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "SetDrawRangeToContainCaretPosition", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateCaret", MemberParameters = new object[]
			{
				"UnityEngine.UI.VertexHelper",
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateHighlight", MemberParameters = new object[]
			{
				"UnityEngine.UI.VertexHelper",
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000016 RID: 22 RVA: 0x0000208F File Offset: 0x0000028F
		[global::Cpp2ILInjected.Token(Token = "0x17000004")]
		public IList<UILineInfo> lines
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000016")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA55E0", Offset = "0x1FA55E0", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "GetUnclampedCharacterLineFromPosition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(TextGenerator)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "GetCharacterIndexFromPosition", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "DetermineCharacterLine", MemberParameters = new object[]
			{
				typeof(int),
				typeof(TextGenerator)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "LineUpCharacterPosition", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "LineDownCharacterPosition", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "GetLineStartPosition", MemberParameters = new object[]
			{
				typeof(TextGenerator),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "GetLineEndPosition", MemberParameters = new object[]
			{
				typeof(TextGenerator),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "SetDrawRangeToContainCaretPosition", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateCaret", MemberParameters = new object[]
			{
				"UnityEngine.UI.VertexHelper",
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateHighlight", MemberParameters = new object[]
			{
				"UnityEngine.UI.VertexHelper",
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002092 File Offset: 0x00000292
		[global::Cpp2ILInjected.Token(Token = "0x17000005")]
		public Rect rectExtents
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000017")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA4F8C", Offset = "0x1FA4F8C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "SetDrawRangeToContainCaretPosition", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextGenerator), Member = "GetPreferredWidth", MemberParameters = new object[]
			{
				typeof(string),
				typeof(TextGenerationSettings)
			}, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextGenerator), Member = "GetPreferredHeight", MemberParameters = new object[]
			{
				typeof(string),
				typeof(TextGenerationSettings)
			}, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000018 RID: 24
		[global::Cpp2ILInjected.Token(Token = "0x17000006")]
		public extern int characterCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000018")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA4A24", Offset = "0x1FA4A24", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateHighlight", MemberParameters = new object[]
			{
				"UnityEngine.UI.VertexHelper",
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000019 RID: 25
		[global::Cpp2ILInjected.Token(Token = "0x17000007")]
		public extern int lineCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000019")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA5680", Offset = "0x1FA5680", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "GetUnclampedCharacterLineFromPosition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(TextGenerator)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "GetCharacterIndexFromPosition", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "DetermineCharacterLine", MemberParameters = new object[]
			{
				typeof(int),
				typeof(TextGenerator)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "LineDownCharacterPosition", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "SetDrawRangeToContainCaretPosition", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateCaret", MemberParameters = new object[]
			{
				"UnityEngine.UI.VertexHelper",
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateHighlight", MemberParameters = new object[]
			{
				"UnityEngine.UI.VertexHelper",
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x0600001A RID: 26
		[NativeMethod(IsThreadSafe = true)]
		[global::Cpp2ILInjected.Token(Token = "0x600001A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA47CC", Offset = "0x1FA47CC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern IntPtr Internal_Create();

		// Token: 0x0600001B RID: 27
		[NativeMethod(IsThreadSafe = true)]
		[global::Cpp2ILInjected.Token(Token = "0x600001B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA49A4", Offset = "0x1FA49A4", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void Internal_Destroy(IntPtr ptr);

		// Token: 0x0600001C RID: 28 RVA: 0x00002095 File Offset: 0x00000295
		[global::Cpp2ILInjected.Token(Token = "0x600001C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA56BC", Offset = "0x1FA56BC", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextGenerator), Member = "Populate_Internal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Font),
			typeof(Color),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(FontStyle),
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(int),
			typeof(VerticalWrapMode),
			typeof(HorizontalWrapMode),
			typeof(bool),
			typeof(TextAnchor),
			typeof(Vector2),
			typeof(Vector2),
			typeof(bool),
			typeof(bool),
			typeof(ref TextGenerationError)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error)
		{
			throw null;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002098 File Offset: 0x00000298
		[global::Cpp2ILInjected.Token(Token = "0x600001D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA537C", Offset = "0x1FA537C", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextGenerator), Member = "PopulateAlways", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TextGenerationSettings)
		}, ReturnType = typeof(TextGenerationError))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerator), Member = "Populate_Internal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Font),
			typeof(Color),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(FontStyle),
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(TextAnchor),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(bool),
			typeof(bool),
			typeof(ref uint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, VerticalWrapMode verticalOverFlow, HorizontalWrapMode horizontalOverflow, bool updateBounds, TextAnchor anchor, Vector2 extents, Vector2 pivot, bool generateOutOfBounds, bool alignByGeometry, out TextGenerationError error)
		{
			throw null;
		}

		// Token: 0x0600001E RID: 30
		[NativeThrows]
		[global::Cpp2ILInjected.Token(Token = "0x600001E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA4E84", Offset = "0x1FA4E84", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void GetVerticesInternal(object vertices);

		// Token: 0x0600001F RID: 31
		[NativeThrows]
		[global::Cpp2ILInjected.Token(Token = "0x600001F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA4D74", Offset = "0x1FA4D74", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void GetCharactersInternal(object characters);

		// Token: 0x06000020 RID: 32
		[NativeThrows]
		[global::Cpp2ILInjected.Token(Token = "0x6000020")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA4DFC", Offset = "0x1FA4DFC", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void GetLinesInternal(object lines);

		// Token: 0x06000021 RID: 33
		[global::Cpp2ILInjected.Token(Token = "0x6000021")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA563C", Offset = "0x1FA563C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void get_rectExtents_Injected(out Rect ret);

		// Token: 0x06000022 RID: 34
		[global::Cpp2ILInjected.Token(Token = "0x6000022")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA5808", Offset = "0x1FA5808", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern bool Populate_Internal_Injected(string str, Font font, ref Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error);

		// Token: 0x0400001D RID: 29
		[global::Cpp2ILInjected.Token(Token = "0x400001D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal IntPtr m_Ptr;

		// Token: 0x0400001E RID: 30
		[global::Cpp2ILInjected.Token(Token = "0x400001E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string m_LastString;

		// Token: 0x0400001F RID: 31
		[global::Cpp2ILInjected.Token(Token = "0x400001F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private TextGenerationSettings m_LastSettings;

		// Token: 0x04000020 RID: 32
		[global::Cpp2ILInjected.Token(Token = "0x4000020")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private bool m_HasGenerated;

		// Token: 0x04000021 RID: 33
		[global::Cpp2ILInjected.Token(Token = "0x4000021")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
		private TextGenerationError m_LastValid;

		// Token: 0x04000022 RID: 34
		[global::Cpp2ILInjected.Token(Token = "0x4000022")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private readonly List<UIVertex> m_Verts;

		// Token: 0x04000023 RID: 35
		[global::Cpp2ILInjected.Token(Token = "0x4000023")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private readonly List<UICharInfo> m_Characters;

		// Token: 0x04000024 RID: 36
		[global::Cpp2ILInjected.Token(Token = "0x4000024")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private readonly List<UILineInfo> m_Lines;

		// Token: 0x04000025 RID: 37
		[global::Cpp2ILInjected.Token(Token = "0x4000025")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private bool m_CachedVerts;

		// Token: 0x04000026 RID: 38
		[global::Cpp2ILInjected.Token(Token = "0x4000026")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA1")]
		private bool m_CachedCharacters;

		// Token: 0x04000027 RID: 39
		[global::Cpp2ILInjected.Token(Token = "0x4000027")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA2")]
		private bool m_CachedLines;
	}
}
