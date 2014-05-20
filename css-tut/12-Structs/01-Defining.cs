/// <summary>
/// Custom struct type represeinting a rectangle
/// </summary>
struct Rectangle
{
  /// <summary>
  /// Backing store for width.
  /// </summary>
  private int m_width;

  /// <summary>
  /// Width of rectangle
  /// </summary>
  public int Width
  {
    get
    {
      return m_width;
    }
    set
    {
      m_width = value;
    }
  }

  /// <summary>
  /// Backing store for height.
  /// </summary>
  private int m_height;

  /// <summary>
  /// Height of rectangle
  /// </summary>
  public int Height
  {
    get
    {
      return m_height;
    }
    set
    {
      m_height = value;
    }
  }
}

