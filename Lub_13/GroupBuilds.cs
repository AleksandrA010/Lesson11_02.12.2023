using System;

namespace Lub_13
{
    internal class GroupBuilds
    {
        public Build[] builds {  get; }
        public Build this[int index]
        {
            get { return builds[index]; }
        }
        public GroupBuilds(Build[] builds)
        {
            this.builds = builds;
        }
    }
}
