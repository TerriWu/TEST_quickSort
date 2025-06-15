using Microsoft.AspNetCore.Mvc;
using quickSort.Model;

namespace quickSort.Controllers
{
    public class QuickSort : Controller
    {

        private static int sortCount = 0;

        /// <summary>
        /// 快速排序
        /// </summary>
        /// <param name="quickSortReceive"></param>
        /// <returns></returns>
        [Route("/api/QuickSortTest")]
        [HttpPost]
        public IActionResult QuickSortTest(QuickSortReceive quickSortReceive)
        {
            QuickSortReturn quickSortReturn = new QuickSortReturn();

            try
            {

                // 使用快速排序對數組進行排序
                quickSort(quickSortReceive.Data, 0, quickSortReceive.Data.Length - 1);

                quickSortReturn.SortData = quickSortReceive.Data;
                quickSortReturn.SortCount = sortCount;

                return Ok(quickSortReturn);
            }
            catch (Exception ex) { 

                quickSortReturn.Message = ex.Message;  
                return BadRequest(quickSortReturn);
            }
        }

        private static bool quickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(array, left, right);
                quickSort(array, left, pivotIndex - 1);
                quickSort(array, pivotIndex + 1, right);
            }

            return true;
        }

        private static int Partition(int[] array, int left, int right)
        {
            int pivot = array[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            Swap(array, i + 1, right);

            sortCount += 1;

            return i + 1;
        }

        private static void Swap(int[] array, int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }

    }
}
