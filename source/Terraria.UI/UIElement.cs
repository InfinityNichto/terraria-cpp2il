using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;

namespace Terraria.UI;

[Cpp2IlInjected.Token(Token = "0x20004D3")]
public class UIElement : IComparable
{
	[Cpp2IlInjected.Token(Token = "0x2000951")]
	public delegate void MouseEvent(UIMouseEvent evt, UIElement listeningElement);

	[Cpp2IlInjected.Token(Token = "0x2000952")]
	public delegate void ScrollWheelEvent(UIScrollWheelEvent evt, UIElement listeningElement);

	[Cpp2IlInjected.Token(Token = "0x2000953")]
	public delegate void ElementEvent(UIElement affectedElement);

	[Cpp2IlInjected.Token(Token = "0x2000954")]
	public delegate void UIElementAction(UIElement element);

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40066BC")]
	protected readonly List<UIElement> Elements;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40066BE")]
	public StyleDimension Top;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40066BF")]
	public StyleDimension Left;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40066C0")]
	public StyleDimension Width;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40066C1")]
	public StyleDimension Height;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40066C2")]
	public StyleDimension MaxWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40066C3")]
	public StyleDimension MaxHeight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40066C4")]
	public StyleDimension MinWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40066C5")]
	public StyleDimension MinHeight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40066D2")]
	private bool _isInitialized;

	[Cpp2IlInjected.FieldOffset(Offset = "0x85")]
	[Cpp2IlInjected.Token(Token = "0x40066D3")]
	public bool IgnoresMouseInteraction;

	[Cpp2IlInjected.FieldOffset(Offset = "0x86")]
	[Cpp2IlInjected.Token(Token = "0x40066D4")]
	public bool OverflowHidden;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40066D5")]
	public SamplerState OverrideSamplerState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x40066D6")]
	public float PaddingTop;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40066D7")]
	public float PaddingLeft;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40066D8")]
	public float PaddingRight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40066D9")]
	public float PaddingBottom;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40066DA")]
	public float MarginTop;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40066DB")]
	public float MarginLeft;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x40066DC")]
	public float MarginRight;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40066DD")]
	public float MarginBottom;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40066DE")]
	public float HAlign;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40066DF")]
	public float VAlign;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40066E0")]
	private CalculatedStyle _innerDimensions;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40066E1")]
	private CalculatedStyle _dimensions;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40066E2")]
	private CalculatedStyle _outerDimensions;

	[Cpp2IlInjected.Token(Token = "0x40066E3")]
	private static readonly RasterizerState OverflowHiddenRasterizerState;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40066E4")]
	public bool UseImmediateMode;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40066E5")]
	private SnapPoint _snapPoint;

	[Cpp2IlInjected.Token(Token = "0x40066E7")]
	private static int _idCounter;

	[Cpp2IlInjected.Token(Token = "0x170006CB")]
	public UIElement Parent
	{
		[Cpp2IlInjected.Token(Token = "0x6003630")]
		[Cpp2IlInjected.Address(RVA = "0x1344F04", Offset = "0x1344F04", VA = "0x1344F04")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6003631")]
		[Cpp2IlInjected.Address(RVA = "0x1344F0C", Offset = "0x1344F0C", VA = "0x1344F0C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170006CC")]
	public int UniqueId
	{
		[Cpp2IlInjected.Token(Token = "0x6003632")]
		[Cpp2IlInjected.Address(RVA = "0x1344F14", Offset = "0x1344F14", VA = "0x1344F14")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6003633")]
		[Cpp2IlInjected.Address(RVA = "0x1344F1C", Offset = "0x1344F1C", VA = "0x1344F1C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170006CD")]
	public IEnumerable<UIElement> Children
	{
		[Cpp2IlInjected.Token(Token = "0x6003634")]
		[Cpp2IlInjected.Address(RVA = "0x1344F24", Offset = "0x1344F24", VA = "0x1344F24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170006CE")]
	public bool IsMouseHovering
	{
		[Cpp2IlInjected.Token(Token = "0x600364D")]
		[Cpp2IlInjected.Address(RVA = "0x1345FAC", Offset = "0x1345FAC", VA = "0x1345FAC")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600364E")]
		[Cpp2IlInjected.Address(RVA = "0x1345FB4", Offset = "0x1345FB4", VA = "0x1345FB4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event MouseEvent OnLeftMouseDown
	{
		[Cpp2IlInjected.Token(Token = "0x6003635")]
		[Cpp2IlInjected.Address(RVA = "0x1344F2C", Offset = "0x1344F2C", VA = "0x1344F2C")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6003636")]
		[Cpp2IlInjected.Address(RVA = "0x1344FDC", Offset = "0x1344FDC", VA = "0x1344FDC")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event MouseEvent OnLeftMouseUp
	{
		[Cpp2IlInjected.Token(Token = "0x6003637")]
		[Cpp2IlInjected.Address(RVA = "0x134508C", Offset = "0x134508C", VA = "0x134508C")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6003638")]
		[Cpp2IlInjected.Address(RVA = "0x134513C", Offset = "0x134513C", VA = "0x134513C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event MouseEvent OnLeftClick
	{
		[Cpp2IlInjected.Token(Token = "0x6003639")]
		[Cpp2IlInjected.Address(RVA = "0x13451EC", Offset = "0x13451EC", VA = "0x13451EC")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600363A")]
		[Cpp2IlInjected.Address(RVA = "0x134529C", Offset = "0x134529C", VA = "0x134529C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event MouseEvent OnLeftDoubleClick
	{
		[Cpp2IlInjected.Token(Token = "0x600363B")]
		[Cpp2IlInjected.Address(RVA = "0x134534C", Offset = "0x134534C", VA = "0x134534C")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600363C")]
		[Cpp2IlInjected.Address(RVA = "0x13453FC", Offset = "0x13453FC", VA = "0x13453FC")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event MouseEvent OnRightMouseDown
	{
		[Cpp2IlInjected.Token(Token = "0x600363D")]
		[Cpp2IlInjected.Address(RVA = "0x13454AC", Offset = "0x13454AC", VA = "0x13454AC")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600363E")]
		[Cpp2IlInjected.Address(RVA = "0x134555C", Offset = "0x134555C", VA = "0x134555C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event MouseEvent OnRightMouseUp
	{
		[Cpp2IlInjected.Token(Token = "0x600363F")]
		[Cpp2IlInjected.Address(RVA = "0x134560C", Offset = "0x134560C", VA = "0x134560C")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6003640")]
		[Cpp2IlInjected.Address(RVA = "0x13456BC", Offset = "0x13456BC", VA = "0x13456BC")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event MouseEvent OnRightClick
	{
		[Cpp2IlInjected.Token(Token = "0x6003641")]
		[Cpp2IlInjected.Address(RVA = "0x134576C", Offset = "0x134576C", VA = "0x134576C")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6003642")]
		[Cpp2IlInjected.Address(RVA = "0x134581C", Offset = "0x134581C", VA = "0x134581C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event MouseEvent OnRightDoubleClick
	{
		[Cpp2IlInjected.Token(Token = "0x6003643")]
		[Cpp2IlInjected.Address(RVA = "0x13458CC", Offset = "0x13458CC", VA = "0x13458CC")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6003644")]
		[Cpp2IlInjected.Address(RVA = "0x134597C", Offset = "0x134597C", VA = "0x134597C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event MouseEvent OnMouseOver
	{
		[Cpp2IlInjected.Token(Token = "0x6003645")]
		[Cpp2IlInjected.Address(RVA = "0x1345A2C", Offset = "0x1345A2C", VA = "0x1345A2C")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6003646")]
		[Cpp2IlInjected.Address(RVA = "0x1345ADC", Offset = "0x1345ADC", VA = "0x1345ADC")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event MouseEvent OnMouseOut
	{
		[Cpp2IlInjected.Token(Token = "0x6003647")]
		[Cpp2IlInjected.Address(RVA = "0x1345B8C", Offset = "0x1345B8C", VA = "0x1345B8C")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6003648")]
		[Cpp2IlInjected.Address(RVA = "0x1345C3C", Offset = "0x1345C3C", VA = "0x1345C3C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event ScrollWheelEvent OnScrollWheel
	{
		[Cpp2IlInjected.Token(Token = "0x6003649")]
		[Cpp2IlInjected.Address(RVA = "0x1345CEC", Offset = "0x1345CEC", VA = "0x1345CEC")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600364A")]
		[Cpp2IlInjected.Address(RVA = "0x1345D9C", Offset = "0x1345D9C", VA = "0x1345D9C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event ElementEvent OnUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x600364B")]
		[Cpp2IlInjected.Address(RVA = "0x1345E4C", Offset = "0x1345E4C", VA = "0x1345E4C")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600364C")]
		[Cpp2IlInjected.Address(RVA = "0x1345EFC", Offset = "0x1345EFC", VA = "0x1345EFC")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600364F")]
	[Cpp2IlInjected.Address(RVA = "0x1345FBC", Offset = "0x1345FBC", VA = "0x1345FBC")]
	public UIElement()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003650")]
	[Cpp2IlInjected.Address(RVA = "0x1346104", Offset = "0x1346104", VA = "0x1346104")]
	public void SetSnapPoint(string name, int id, [Optional] Vector2? anchor, [Optional] Vector2? offset)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003651")]
	[Cpp2IlInjected.Address(RVA = "0x13462E4", Offset = "0x13462E4", VA = "0x13462E4")]
	public bool GetSnapPoint(out SnapPoint point)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003652")]
	[Cpp2IlInjected.Address(RVA = "0x1346324", Offset = "0x1346324", VA = "0x1346324", Slot = "5")]
	public virtual void ExecuteRecursively(UIElementAction action)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003653")]
	[Cpp2IlInjected.Address(RVA = "0x134644C", Offset = "0x134644C", VA = "0x134644C", Slot = "6")]
	protected virtual void DrawSelf(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003654")]
	[Cpp2IlInjected.Address(RVA = "0x1346450", Offset = "0x1346450", VA = "0x1346450", Slot = "7")]
	protected virtual void DrawChildren(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003655")]
	[Cpp2IlInjected.Address(RVA = "0x1346568", Offset = "0x1346568", VA = "0x1346568")]
	public void Append(UIElement element)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003656")]
	[Cpp2IlInjected.Address(RVA = "0x13465F4", Offset = "0x13465F4", VA = "0x13465F4")]
	public void Remove()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003657")]
	[Cpp2IlInjected.Address(RVA = "0x1346608", Offset = "0x1346608", VA = "0x1346608")]
	public void RemoveChild(UIElement child)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003658")]
	[Cpp2IlInjected.Address(RVA = "0x1346674", Offset = "0x1346674", VA = "0x1346674")]
	public void RemoveAllChildren()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003659")]
	[Cpp2IlInjected.Address(RVA = "0x1346790", Offset = "0x1346790", VA = "0x1346790", Slot = "8")]
	public virtual void Draw(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600365A")]
	[Cpp2IlInjected.Address(RVA = "0x1347980", Offset = "0x1347980", VA = "0x1347980", Slot = "9")]
	public virtual void Update(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600365B")]
	[Cpp2IlInjected.Address(RVA = "0x1347304", Offset = "0x1347304", VA = "0x1347304")]
	public Rectangle GetClippingRectangle(SpriteBatch spriteBatch)
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x600365C")]
	[Cpp2IlInjected.Address(RVA = "0x1347AB4", Offset = "0x1347AB4", VA = "0x1347AB4", Slot = "10")]
	public virtual List<SnapPoint> GetSnapPoints()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600365D")]
	[Cpp2IlInjected.Address(RVA = "0x1347C58", Offset = "0x1347C58", VA = "0x1347C58", Slot = "11")]
	public virtual void Recalculate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600365E")]
	[Cpp2IlInjected.Address(RVA = "0x1347E04", Offset = "0x1347E04", VA = "0x1347E04")]
	private CalculatedStyle GetDimensionsBasedOnParentDimensions(CalculatedStyle parentDimensions)
	{
		return default(CalculatedStyle);
	}

	[Cpp2IlInjected.Token(Token = "0x600365F")]
	[Cpp2IlInjected.Address(RVA = "0x1347F24", Offset = "0x1347F24", VA = "0x1347F24")]
	public UIElement GetElementAt(Vector2 point)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003660")]
	[Cpp2IlInjected.Address(RVA = "0x1348048", Offset = "0x1348048", VA = "0x1348048", Slot = "12")]
	public virtual bool ContainsPoint(Vector2 point)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003661")]
	[Cpp2IlInjected.Address(RVA = "0x13480A8", Offset = "0x13480A8", VA = "0x13480A8", Slot = "13")]
	public virtual Rectangle GetViewCullingArea()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6003662")]
	[Cpp2IlInjected.Address(RVA = "0x13480C0", Offset = "0x13480C0", VA = "0x13480C0")]
	public void SetPadding(float pixels)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003663")]
	[Cpp2IlInjected.Address(RVA = "0x13480D0", Offset = "0x13480D0", VA = "0x13480D0", Slot = "14")]
	public virtual void RecalculateChildren()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003664")]
	[Cpp2IlInjected.Address(RVA = "0x13481E0", Offset = "0x13481E0", VA = "0x13481E0")]
	public CalculatedStyle GetInnerDimensions()
	{
		return default(CalculatedStyle);
	}

	[Cpp2IlInjected.Token(Token = "0x6003665")]
	[Cpp2IlInjected.Address(RVA = "0x13481F0", Offset = "0x13481F0", VA = "0x13481F0")]
	public CalculatedStyle GetDimensions()
	{
		return default(CalculatedStyle);
	}

	[Cpp2IlInjected.Token(Token = "0x6003666")]
	[Cpp2IlInjected.Address(RVA = "0x1348200", Offset = "0x1348200", VA = "0x1348200")]
	public CalculatedStyle GetOuterDimensions()
	{
		return default(CalculatedStyle);
	}

	[Cpp2IlInjected.Token(Token = "0x6003667")]
	[Cpp2IlInjected.Address(RVA = "0x1348210", Offset = "0x1348210", VA = "0x1348210")]
	public void CopyStyle(UIElement element)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003668")]
	[Cpp2IlInjected.Address(RVA = "0x13482D0", Offset = "0x13482D0", VA = "0x13482D0", Slot = "15")]
	public virtual void LeftMouseDown(UIMouseEvent evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003669")]
	[Cpp2IlInjected.Address(RVA = "0x1348324", Offset = "0x1348324", VA = "0x1348324", Slot = "16")]
	public virtual void LeftMouseUp(UIMouseEvent evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600366A")]
	[Cpp2IlInjected.Address(RVA = "0x1348378", Offset = "0x1348378", VA = "0x1348378", Slot = "17")]
	public virtual void LeftClick(UIMouseEvent evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600366B")]
	[Cpp2IlInjected.Address(RVA = "0x13483CC", Offset = "0x13483CC", VA = "0x13483CC", Slot = "18")]
	public virtual void LeftDoubleClick(UIMouseEvent evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600366C")]
	[Cpp2IlInjected.Address(RVA = "0x1348420", Offset = "0x1348420", VA = "0x1348420", Slot = "19")]
	public virtual void RightMouseDown(UIMouseEvent evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600366D")]
	[Cpp2IlInjected.Address(RVA = "0x1348474", Offset = "0x1348474", VA = "0x1348474", Slot = "20")]
	public virtual void RightMouseUp(UIMouseEvent evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600366E")]
	[Cpp2IlInjected.Address(RVA = "0x13484C8", Offset = "0x13484C8", VA = "0x13484C8", Slot = "21")]
	public virtual void RightClick(UIMouseEvent evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600366F")]
	[Cpp2IlInjected.Address(RVA = "0x134851C", Offset = "0x134851C", VA = "0x134851C", Slot = "22")]
	public virtual void RightDoubleClick(UIMouseEvent evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003670")]
	[Cpp2IlInjected.Address(RVA = "0x1348570", Offset = "0x1348570", VA = "0x1348570", Slot = "23")]
	public virtual void MouseOver(UIMouseEvent evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003671")]
	[Cpp2IlInjected.Address(RVA = "0x13485CC", Offset = "0x13485CC", VA = "0x13485CC", Slot = "24")]
	public virtual void MouseOut(UIMouseEvent evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003672")]
	[Cpp2IlInjected.Address(RVA = "0x1348628", Offset = "0x1348628", VA = "0x1348628", Slot = "25")]
	public virtual void ScrollWheel(UIScrollWheelEvent evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003673")]
	[Cpp2IlInjected.Address(RVA = "0x134867C", Offset = "0x134867C", VA = "0x134867C")]
	public void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003674")]
	[Cpp2IlInjected.Address(RVA = "0x13487EC", Offset = "0x13487EC", VA = "0x13487EC", Slot = "26")]
	public virtual void OnActivate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003675")]
	[Cpp2IlInjected.Address(RVA = "0x13487F0", Offset = "0x13487F0", VA = "0x13487F0")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x394354", Offset = "0x394354")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x394354", Offset = "0x394354")]
	public void DrawDebugHitbox(BasicDebugDrawer drawer, float colorIntensity = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003676")]
	[Cpp2IlInjected.Address(RVA = "0x1348BFC", Offset = "0x1348BFC", VA = "0x1348BFC")]
	public void Deactivate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003677")]
	[Cpp2IlInjected.Address(RVA = "0x1348D14", Offset = "0x1348D14", VA = "0x1348D14", Slot = "27")]
	public virtual void OnDeactivate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003678")]
	[Cpp2IlInjected.Address(RVA = "0x13487C0", Offset = "0x13487C0", VA = "0x13487C0")]
	public void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003679")]
	[Cpp2IlInjected.Address(RVA = "0x1348D18", Offset = "0x1348D18", VA = "0x1348D18", Slot = "28")]
	public virtual void OnInitialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600367A")]
	[Cpp2IlInjected.Address(RVA = "0x1348D1C", Offset = "0x1348D1C", VA = "0x1348D1C", Slot = "29")]
	public virtual int CompareTo(object obj)
	{
		return default(int);
	}
}
