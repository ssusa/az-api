namespace az_api.Models;

/// <summary>
/// 部署モデル
/// </summary>
public class t_busyo
{
    /// <summary>
    /// ID
    /// </summary>
    public long id { get; set; }

    /// <summary>
    /// 部署コード
    /// </summary>
    public string busyo_cd { get; set; } = string.Empty;

    /// <summary>
    /// 部署名
    /// </summary>
    public string busyo_name { get; set; } = string.Empty;
}
