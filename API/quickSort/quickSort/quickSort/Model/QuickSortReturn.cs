namespace quickSort.Model
{
    public class QuickSortReturn
    {
        /// <summary>
        /// 錯誤訊息
        /// </summary>
        public String Message {  get; set; }
        /// <summary>
        /// 排序結果
        /// </summary>
        public int [] SortData {  get; set; }
        /// <summary>
        /// 排序次數
        /// </summary>
        public int SortCount {  get; set; }
    }
}
