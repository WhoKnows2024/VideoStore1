using api.DTOs.Customers;
using api.DTOs.Inventory;
using api.Models;
using System.Runtime.CompilerServices;

namespace api.Mapper
{
    public static class InvCommentMapper
    {
        public static UpdateInvCommentDTO ToInvCommentDTO(this UpdateInvCommentDTO invCommentModel) 
        {
            return new UpdateInvCommentDTO
            {
                InvCommentId = invCommentModel.InvCommentId,
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
                InvComment = invCommentDTO.InvComments,
                Entered = invCommentDTO.Entered
            };

        }

    }
     
 }
