namespace az_api.Models;

/// <summary>
/// 社員モデル
/// </summary>
public class t_syain
{
    /// <summary>
    /// ID
    /// </summary>
    public long id { get; set; }

    /// <summary>
    /// 社員コード
    /// </summary>
    public string syain_cd { get; set; } = string.Empty;

    /// <summary>
    /// 社員名
    /// </summary>
    public string syain_name { get; set; } = string.Empty;
}
