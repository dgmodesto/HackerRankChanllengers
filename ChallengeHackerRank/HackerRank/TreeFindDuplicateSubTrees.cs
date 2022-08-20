using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static ChallengeHackerRank.FindDuplicateSubTrees;

namespace ChallengeHackerRank
{
    /**
       * Definition for a binary tree node.
       */
    public class TreeNodeDuplicateSubTrees
    {
        public int val;
        public TreeNodeDuplicateSubTrees left;
        public TreeNodeDuplicateSubTrees right;
        public TreeNodeDuplicateSubTrees() { }
        public TreeNodeDuplicateSubTrees(int val) { this.val = val; }
        public TreeNodeDuplicateSubTrees(int val, TreeNodeDuplicateSubTrees left, TreeNodeDuplicateSubTrees right)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }


    public static class TreeFindDuplicateSubTrees
    {
       
        
        public static IList<TreeNodeDuplicateSubTrees> FindDuplicateSubtrees(TreeNodeDuplicateSubTrees root)
        {
            var result = new ResultTreeNodeDuplicate();
            return result.GetDuplicateSubTrees(root);
        }

        public static void Initial(string[] args)
        {
            var input = new string [] { "1","2","3","4",null, null, "4"  };




        }


    }

    public class ResultTreeNodeDuplicate
    {
        private HashSet<TreeNodeDuplicateSubTrees> nodes = new HashSet<TreeNodeDuplicateSubTrees>();

        public IList<TreeNodeDuplicateSubTrees> GetDuplicateSubTrees(TreeNodeDuplicateSubTrees root)
        {

            Dictionary<string, TreeNodeDuplicateSubTrees> dic = new Dictionary<string, TreeNodeDuplicateSubTrees>();
            var result = new ResultTreeNodeDuplicate();
            var res = result.FindSubTreeDuplicates(root, dic);

            return new HashSet<TreeNodeDuplicateSubTrees>(nodes).ToList();
        }

        public string FindSubTreeDuplicates(TreeNodeDuplicateSubTrees root, Dictionary<string, TreeNodeDuplicateSubTrees> dic)
        {
            if (root == null) return "#";

            string value = root.val.ToString();
            string leftSubTreeValues = FindSubTreeDuplicates(root.left, dic);
            string rightSubTreeValues = FindSubTreeDuplicates(root.right, dic);

            string currentValue = string.Join(",", value, leftSubTreeValues, rightSubTreeValues);

            if(dic.ContainsKey(currentValue) ){
                nodes.Add(dic[currentValue]);
            } else
            {
                dic.Add(currentValue, root);
            }

            return currentValue;
        }
    }
}
