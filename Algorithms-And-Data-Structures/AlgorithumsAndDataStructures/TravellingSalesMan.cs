using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithumsAndDataStructures
{
    public class TravellingSale
    {

        static int salesPerson(int[,] graph, bool[] v, int currentPosition,
                int n, int count, int cost, int ans)
        {

            // If last node is reached and it has a link
            // to the starting node i.e the source then
            // keep the minimum value out of the total cost
            // of traversal and "ans"
            // Finally return to check for more possible values
            if (count == n && graph[currentPosition, 0] > 0)
            {
                ans = Math.Min(ans, cost + graph[currentPosition, 0]);
                return ans;
            }

            // BACKTRACKING STEP
            // Loop to traverse the adjacency list
            // of currPosition node and increasing the count
            // by 1 and cost by graph[currPosition,i] value
            for (int i = 0; i < n; i++)
            {
                if (v[i] == false && graph[currentPosition, i] > 0)
                {

                    // Mark as visited
                    v[i] = true;
                    ans = salesPerson(graph, v, i, n, count + 1,
                        cost + graph[currentPosition, i], ans);

                    // Mark ith node as unvisited
                    v[i] = false;
                }
            }
            return ans;
        }

       
    }
}

