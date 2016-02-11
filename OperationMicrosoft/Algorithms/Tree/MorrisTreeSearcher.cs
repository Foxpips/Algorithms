using OperationMicrosoft.DataStructures.Objects;

namespace OperationMicrosoft.Algorithms.Tree
{
    public class MorrisTreeSearcher
    {
        public TreeNode<TValue> InorderSuccessor<TValue>(TreeNode<TValue> root, TreeNode<TValue> p)
        {
            var curr = root;
            TreeNode<TValue> prev = null;

            while (curr != null)
            {
                if (curr.Left == null)
                {
                    /* addition to morris traversal */
                    if (prev == p) break;
                    prev = curr;
                    /* end of addition to morris traversal */
                    curr = curr.Right;
                }
                else
                {
                    TreeNode<TValue> predecessor = curr.Left;
                    while (predecessor.Right != null && predecessor.Right != curr)
                    {
                        predecessor = predecessor.Right;
                    }

                    if (predecessor.Right == null)
                    {
                        predecessor.Right = curr;
                        curr = curr.Left;
                    }
                    else
                    {
                        /* addition to morris traversal */
                        if (prev == p) break;
                        prev = curr;
                        /* end of addition to morris traversal */
                        predecessor.Right = null;
                        curr = curr.Right;
                    }
                }
            }

            return curr;
        } 
    }
}