namespace az_api.Models;

/// <summary>
/// 所属モデル
/// </summary>
public class t_syozoku
{
    /// <summary>
    /// ID
    /// </summary>
    public long id { get; set; }

    /// <summary>
    /// 社員ID
    /// </summary>
    public long t_syain_id { get; set; }

    /// <summary>
    /// 部署ID
    /// </summary>
    public long t_busyo_id { get; set; }

    /// <summary>
    /// 開始日
    /// </summary>
    public DateTime start_date { get; set; }

    /// <summary>
    /// 社員ナビゲーションプロパティ
    /// </summary>
    public t_syain? t_syain { get; set; }

    /// <summary>
    /// 部署ナビゲーションプロパティ
    /// </summary>
    public t_busyo? t_busyo { get; set; }
}
