using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Post.Cmd.Api.Commands
{
    public class RemoveCommentCommand
    {
        public Guid CommentId { get; set; }
        public string? UserName { get; set; }
    }
}