using Blazored.Video.Support;
using BootstrapBlazor.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ice_KnowledgeLibrary.Pages
{
    public partial class VideoCourse
    {
        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
        }

        private IEnumerable<TreeItem> Items { get; set; } = GetItems();

        protected static IEnumerable<TreeItem> GetItems()
        {
            var ret = new List<TreeItem>
            {
                new TreeItem() { Text = "导航一" },
                new TreeItem() { Text = "导航二" },
                new TreeItem() { Text = "导航三" }
            };

            ret[0].AddItem(new TreeItem() { Text = "子菜单" });

            ret[1].AddItem(new TreeItem() { Text = "子菜单一" });
            ret[1].AddItem(new TreeItem() { Text = "子菜单二" });
            ret[1].AddItem(new TreeItem() { Text = "子菜单三" });

            ret[1].Items.ElementAt(0).AddItem(new TreeItem() { Text = "孙菜单1一" });
            ret[1].Items.ElementAt(0).AddItem(new TreeItem() { Text = "孙菜单1二" });

            ret[1].Items.ElementAt(1).AddItem(new TreeItem() { Text = "孙菜单2一" });
            ret[1].Items.ElementAt(1).AddItem(new TreeItem() { Text = "孙菜单2二" });

            ret[1].Items.ElementAt(1).Items.ElementAt(1).AddItem(new TreeItem() { Text = "曾孙菜单一" });
            ret[1].Items.ElementAt(1).Items.ElementAt(1).AddItem(new TreeItem() { Text = "曾孙菜单二" });

            ret[1].Items.ElementAt(1).Items.ElementAt(1).Items.ElementAt(1).AddItem(new TreeItem() { Text = "曾曾孙菜单一" });
            ret[1].Items.ElementAt(1).Items.ElementAt(1).Items.ElementAt(1).AddItem(new TreeItem() { Text = "曾曾孙菜单二" });

            return ret;
        }
        public Task OnTreeItemClick(TreeItem item)
        {
            // 用于通知界面有更新，需要重新渲染界面，此句必须加，否则界面不刷新。
            this.StateHasChanged();
            return Task.CompletedTask;
        }


        void OnPlay(VideoState state)
        {
            var url = state.CurrentSrc;
            // do something with this
        }
        void OnTimeUpdate(VideoState state)
        {
            var url = state.CurrentSrc;
            var currentTime = state.CurrentTime;
            // do something with this
        }
    }
}
