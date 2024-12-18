using api.DTOs.Customers;
using api.DTOs.Inventory;
using api.Models;
using System.Runtime.CompilerServices;

namespace api.Mapper
{
    public static class InvCommentMapper
    {
        public static InvCommentDTO ToInvCommentDTO(this InvCommentDTO invCommentModel) 
        {
            return new InvCommentDTO
            {
                // invComment = invCommentModel.InvCommentId;
                InvId = invCommentModel.InvId,
                InvComments = invCommentModel.InvComments,
                Entered = invCommentModel.Entered
            };
        }
        public static InvComments ToInvCommentFromCreateDTO(this CreateInvCommentRequestDTO invCommentDTO)
        {
            return new InvComments
            {
                InvCommentId = invCommentDTO.InvCommentId,
                InvId = invCommentDTO.InvId,
                InvComment = invCommentDTO.InvComment,
                Entered = invCommentDTO.Entered
            };

        }

    }
     
 }
