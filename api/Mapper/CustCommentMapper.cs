using api.DTOs.Customers;
using api.Models;

namespace api.Mapper
{
    public static class CustCommentMapper
    {
        public static CustCommentDTO ToCustCommentDTO(this CustComments custCommentModel)
        {
            CustCommentDTO custComment = new()
            {
                CustCommentId = custCommentModel.CustCommentId,
                CustId = custCommentModel.CustId,
                CustComment = custCommentModel.CustComment,
                Entered = custCommentModel.Entered,
            };
            return custComment;
        }

        public static CustComments ToCustCommentFromCreateDTO(this CreateCustCommentRequestDTO custCommentDTO)
        {               
            return new CustComments
            {
                CustId = custCommentDTO.CustId,
                CustComment = custCommentDTO.CustComment,
                Entered = custCommentDTO.Entered
            };
    }
        }
            
    
}
