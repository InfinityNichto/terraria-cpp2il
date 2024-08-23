using System;
using System.ComponentModel;
using Cpp2ILInjected;

namespace UnityEngine
{
	// Token: 0x02000008 RID: 8
	[global::Cpp2ILInjected.Token(Token = "0x2000009")]
	public enum EventType
	{
		// Token: 0x04000021 RID: 33
		[global::Cpp2ILInjected.Token(Token = "0x4000021")]
		MouseDown,
		// Token: 0x04000022 RID: 34
		[global::Cpp2ILInjected.Token(Token = "0x4000022")]
		MouseUp,
		// Token: 0x04000023 RID: 35
		[global::Cpp2ILInjected.Token(Token = "0x4000023")]
		MouseMove,
		// Token: 0x04000024 RID: 36
		[global::Cpp2ILInjected.Token(Token = "0x4000024")]
		MouseDrag,
		// Token: 0x04000025 RID: 37
		[global::Cpp2ILInjected.Token(Token = "0x4000025")]
		KeyDown,
		// Token: 0x04000026 RID: 38
		[global::Cpp2ILInjected.Token(Token = "0x4000026")]
		KeyUp,
		// Token: 0x04000027 RID: 39
		[global::Cpp2ILInjected.Token(Token = "0x4000027")]
		ScrollWheel,
		// Token: 0x04000028 RID: 40
		[global::Cpp2ILInjected.Token(Token = "0x4000028")]
		Repaint,
		// Token: 0x04000029 RID: 41
		[global::Cpp2ILInjected.Token(Token = "0x4000029")]
		Layout,
		// Token: 0x0400002A RID: 42
		[global::Cpp2ILInjected.Token(Token = "0x400002A")]
		DragUpdated,
		// Token: 0x0400002B RID: 43
		[global::Cpp2ILInjected.Token(Token = "0x400002B")]
		DragPerform,
		// Token: 0x0400002C RID: 44
		[global::Cpp2ILInjected.Token(Token = "0x400002C")]
		DragExited = 15,
		// Token: 0x0400002D RID: 45
		[global::Cpp2ILInjected.Token(Token = "0x400002D")]
		Ignore = 11,
		// Token: 0x0400002E RID: 46
		[global::Cpp2ILInjected.Token(Token = "0x400002E")]
		Used,
		// Token: 0x0400002F RID: 47
		[global::Cpp2ILInjected.Token(Token = "0x400002F")]
		ValidateCommand,
		// Token: 0x04000030 RID: 48
		[global::Cpp2ILInjected.Token(Token = "0x4000030")]
		ExecuteCommand,
		// Token: 0x04000031 RID: 49
		[global::Cpp2ILInjected.Token(Token = "0x4000031")]
		ContextClick = 16,
		// Token: 0x04000032 RID: 50
		[global::Cpp2ILInjected.Token(Token = "0x4000032")]
		MouseEnterWindow = 20,
		// Token: 0x04000033 RID: 51
		[global::Cpp2ILInjected.Token(Token = "0x4000033")]
		MouseLeaveWindow,
		// Token: 0x04000034 RID: 52
		[global::Cpp2ILInjected.Token(Token = "0x4000034")]
		TouchDown = 30,
		// Token: 0x04000035 RID: 53
		[global::Cpp2ILInjected.Token(Token = "0x4000035")]
		TouchUp,
		// Token: 0x04000036 RID: 54
		[global::Cpp2ILInjected.Token(Token = "0x4000036")]
		TouchMove,
		// Token: 0x04000037 RID: 55
		[global::Cpp2ILInjected.Token(Token = "0x4000037")]
		TouchEnter,
		// Token: 0x04000038 RID: 56
		[global::Cpp2ILInjected.Token(Token = "0x4000038")]
		TouchLeave,
		// Token: 0x04000039 RID: 57
		[global::Cpp2ILInjected.Token(Token = "0x4000039")]
		TouchStationary,
		// Token: 0x0400003A RID: 58
		[Obsolete("Use MouseDown instead (UnityUpgradable) -> MouseDown", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x400003A")]
		mouseDown = 0,
		// Token: 0x0400003B RID: 59
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use MouseUp instead (UnityUpgradable) -> MouseUp", true)]
		[global::Cpp2ILInjected.Token(Token = "0x400003B")]
		mouseUp,
		// Token: 0x0400003C RID: 60
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use MouseMove instead (UnityUpgradable) -> MouseMove", true)]
		[global::Cpp2ILInjected.Token(Token = "0x400003C")]
		mouseMove,
		// Token: 0x0400003D RID: 61
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use MouseDrag instead (UnityUpgradable) -> MouseDrag", true)]
		[global::Cpp2ILInjected.Token(Token = "0x400003D")]
		mouseDrag,
		// Token: 0x0400003E RID: 62
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use KeyDown instead (UnityUpgradable) -> KeyDown", true)]
		[global::Cpp2ILInjected.Token(Token = "0x400003E")]
		keyDown,
		// Token: 0x0400003F RID: 63
		[Obsolete("Use KeyUp instead (UnityUpgradable) -> KeyUp", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x400003F")]
		keyUp,
		// Token: 0x04000040 RID: 64
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use ScrollWheel instead (UnityUpgradable) -> ScrollWheel", true)]
		[global::Cpp2ILInjected.Token(Token = "0x4000040")]
		scrollWheel,
		// Token: 0x04000041 RID: 65
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use Repaint instead (UnityUpgradable) -> Repaint", true)]
		[global::Cpp2ILInjected.Token(Token = "0x4000041")]
		repaint,
		// Token: 0x04000042 RID: 66
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use Layout instead (UnityUpgradable) -> Layout", true)]
		[global::Cpp2ILInjected.Token(Token = "0x4000042")]
		layout,
		// Token: 0x04000043 RID: 67
		[Obsolete("Use DragUpdated instead (UnityUpgradable) -> DragUpdated", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x4000043")]
		dragUpdated,
		// Token: 0x04000044 RID: 68
		[Obsolete("Use DragPerform instead (UnityUpgradable) -> DragPerform", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x4000044")]
		dragPerform,
		// Token: 0x04000045 RID: 69
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use Ignore instead (UnityUpgradable) -> Ignore", true)]
		[global::Cpp2ILInjected.Token(Token = "0x4000045")]
		ignore,
		// Token: 0x04000046 RID: 70
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use Used instead (UnityUpgradable) -> Used", true)]
		[global::Cpp2ILInjected.Token(Token = "0x4000046")]
		used
	}
}
