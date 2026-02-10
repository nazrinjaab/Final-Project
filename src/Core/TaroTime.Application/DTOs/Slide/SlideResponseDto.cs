using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaroTime.Application.DTOs.Slide
{
    public record SlideResponseDto(
        long Id,
        string Title,
        string ImagePath
        );
}
