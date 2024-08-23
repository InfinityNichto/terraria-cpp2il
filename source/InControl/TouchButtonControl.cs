using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000041 RID: 65
	[global::Cpp2ILInjected.Token(Token = "0x2000046")]
	public class TouchButtonControl : TouchControl
	{
		// Token: 0x06000359 RID: 857 RVA: 0x00002A56 File Offset: 0x00000C56
		[global::Cpp2ILInjected.Token(Token = "0x6000362")]
		[global::Cpp2ILInjected.Address(RVA = "0x199DA58", Offset = "0x199DA58", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void CreateControl()
		{
			throw null;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00002A59 File Offset: 0x00000C59
		[global::Cpp2ILInjected.Token(Token = "0x6000363")]
		[global::Cpp2ILInjected.Address(RVA = "0x199DB08", Offset = "0x199DB08", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchSprite), Member = "Delete", ReturnType = typeof(void))]
		public override void DestroyControl()
		{
			throw null;
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00002A5C File Offset: 0x00000C5C
		[global::Cpp2ILInjected.Token(Token = "0x6000364")]
		[global::Cpp2ILInjected.Address(RVA = "0x199DB9C", Offset = "0x199DB9C", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchControl), Member = "OffsetToWorldPosition", MemberParameters = new object[]
		{
			typeof(TouchControlAnchor),
			typeof(Vector2),
			typeof(TouchUnitType),
			typeof(bool)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchSprite), Member = "Update", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		public override void ConfigureControl()
		{
			throw null;
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00002A5F File Offset: 0x00000C5F
		[global::Cpp2ILInjected.Token(Token = "0x6000365")]
		[global::Cpp2ILInjected.Address(RVA = "0x199DF14", Offset = "0x199DF14", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchButtonControl), Member = "get_ButtonPosition", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchSprite), Member = "DrawGizmos", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Color)
		}, ReturnType = typeof(void))]
		public override void DrawGizmos()
		{
			throw null;
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00002A62 File Offset: 0x00000C62
		[global::Cpp2ILInjected.Token(Token = "0x6000366")]
		[global::Cpp2ILInjected.Address(RVA = "0x199E048", Offset = "0x199E048", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchSprite), Member = "Update", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00002A65 File Offset: 0x00000C65
		[global::Cpp2ILInjected.Token(Token = "0x6000367")]
		[global::Cpp2ILInjected.Address(RVA = "0x199E08C", Offset = "0x199E08C", Length = "0x260")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchControl), Member = "SubmitButtonValue", MemberParameters = new object[]
		{
			typeof(TouchControl.ButtonTarget),
			typeof(float),
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchControl), Member = "SubmitButtonState", MemberParameters = new object[]
		{
			typeof(TouchControl.ButtonTarget),
			typeof(bool),
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "get_TouchCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "GetTouch", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Touch))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchSprite), Member = "Contains", MemberParameters = new object[] { typeof(Touch) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "Max", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void SubmitControlState(ulong updateTick, float deltaTime)
		{
			throw null;
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00002A68 File Offset: 0x00000C68
		[global::Cpp2ILInjected.Token(Token = "0x6000368")]
		[global::Cpp2ILInjected.Address(RVA = "0x199E5F4", Offset = "0x199E5F4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void CommitControlState(ulong updateTick, float deltaTime)
		{
			throw null;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00002A6B File Offset: 0x00000C6B
		[global::Cpp2ILInjected.Token(Token = "0x6000369")]
		[global::Cpp2ILInjected.Address(RVA = "0x199E698", Offset = "0x199E698", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchSprite), Member = "Contains", MemberParameters = new object[] { typeof(Touch) }, ReturnType = typeof(bool))]
		public override void TouchBegan(Touch touch)
		{
			throw null;
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00002A6E File Offset: 0x00000C6E
		[global::Cpp2ILInjected.Token(Token = "0x600036A")]
		[global::Cpp2ILInjected.Address(RVA = "0x199E6F8", Offset = "0x199E6F8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchSprite), Member = "Contains", MemberParameters = new object[] { typeof(Touch) }, ReturnType = typeof(bool))]
		public override void TouchMoved(Touch touch)
		{
			throw null;
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00002A71 File Offset: 0x00000C71
		[global::Cpp2ILInjected.Token(Token = "0x600036B")]
		[global::Cpp2ILInjected.Address(RVA = "0x199E750", Offset = "0x199E750", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void TouchEnded(Touch touch)
		{
			throw null;
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000363 RID: 867 RVA: 0x00002A74 File Offset: 0x00000C74
		// (set) Token: 0x06000364 RID: 868 RVA: 0x00002A77 File Offset: 0x00000C77
		[global::Cpp2ILInjected.Token(Token = "0x17000112")]
		private bool ButtonState
		{
			[global::Cpp2ILInjected.Token(Token = "0x600036C")]
			[global::Cpp2ILInjected.Address(RVA = "0x199E788", Offset = "0x199E788", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600036D")]
			[global::Cpp2ILInjected.Address(RVA = "0x199E434", Offset = "0x199E434", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000365 RID: 869 RVA: 0x00002A7A File Offset: 0x00000C7A
		// (set) Token: 0x06000366 RID: 870 RVA: 0x00002A7D File Offset: 0x00000C7D
		[global::Cpp2ILInjected.Token(Token = "0x17000113")]
		public Vector3 ButtonPosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x600036E")]
			[global::Cpp2ILInjected.Address(RVA = "0x199DF44", Offset = "0x199DF44", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchButtonControl), Member = "DrawGizmos", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchSprite), Member = "get_Position", ReturnType = typeof(Vector3))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600036F")]
			[global::Cpp2ILInjected.Address(RVA = "0x199E864", Offset = "0x199E864", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000367 RID: 871 RVA: 0x00002A80 File Offset: 0x00000C80
		// (set) Token: 0x06000368 RID: 872 RVA: 0x00002A83 File Offset: 0x00000C83
		[global::Cpp2ILInjected.Token(Token = "0x17000114")]
		public TouchControlAnchor Anchor
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000370")]
			[global::Cpp2ILInjected.Address(RVA = "0x199E928", Offset = "0x199E928", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000371")]
			[global::Cpp2ILInjected.Address(RVA = "0x199E930", Offset = "0x199E930", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000369 RID: 873 RVA: 0x00002A86 File Offset: 0x00000C86
		// (set) Token: 0x0600036A RID: 874 RVA: 0x00002A89 File Offset: 0x00000C89
		[global::Cpp2ILInjected.Token(Token = "0x17000115")]
		public Vector2 Offset
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000372")]
			[global::Cpp2ILInjected.Address(RVA = "0x199E94C", Offset = "0x199E94C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000373")]
			[global::Cpp2ILInjected.Address(RVA = "0x199E954", Offset = "0x199E954", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x0600036B RID: 875 RVA: 0x00002A8C File Offset: 0x00000C8C
		// (set) Token: 0x0600036C RID: 876 RVA: 0x00002A8F File Offset: 0x00000C8F
		[global::Cpp2ILInjected.Token(Token = "0x17000116")]
		public TouchUnitType OffsetUnitType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000374")]
			[global::Cpp2ILInjected.Address(RVA = "0x199E98C", Offset = "0x199E98C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000375")]
			[global::Cpp2ILInjected.Address(RVA = "0x199E994", Offset = "0x199E994", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00002A92 File Offset: 0x00000C92
		[global::Cpp2ILInjected.Token(Token = "0x6000376")]
		[global::Cpp2ILInjected.Address(RVA = "0x199E9B0", Offset = "0x199E9B0", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchSprite), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoBehaviour), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public TouchButtonControl()
		{
			throw null;
		}

		// Token: 0x040002DF RID: 735
		[SerializeField]
		[Header("Position")]
		[global::Cpp2ILInjected.Token(Token = "0x40002EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private TouchControlAnchor anchor;

		// Token: 0x040002E0 RID: 736
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40002EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private TouchUnitType offsetUnitType;

		// Token: 0x040002E1 RID: 737
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40002F0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Vector2 offset;

		// Token: 0x040002E2 RID: 738
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40002F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool lockAspectRatio;

		// Token: 0x040002E3 RID: 739
		[Header("Options")]
		[global::Cpp2ILInjected.Token(Token = "0x40002F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		public TouchControl.ButtonTarget target;

		// Token: 0x040002E4 RID: 740
		[global::Cpp2ILInjected.Token(Token = "0x40002F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public bool allowSlideToggle;

		// Token: 0x040002E5 RID: 741
		[global::Cpp2ILInjected.Token(Token = "0x40002F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x31")]
		public bool toggleOnLeave;

		// Token: 0x040002E6 RID: 742
		[global::Cpp2ILInjected.Token(Token = "0x40002F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x32")]
		public bool pressureSensitive;

		// Token: 0x040002E7 RID: 743
		[Header("Sprites")]
		[global::Cpp2ILInjected.Token(Token = "0x40002F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public TouchSprite button;

		// Token: 0x040002E8 RID: 744
		[global::Cpp2ILInjected.Token(Token = "0x40002F7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private bool buttonState;

		// Token: 0x040002E9 RID: 745
		[global::Cpp2ILInjected.Token(Token = "0x40002F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private Touch currentTouch;

		// Token: 0x040002EA RID: 746
		[global::Cpp2ILInjected.Token(Token = "0x40002F9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private bool dirty;
	}
}
