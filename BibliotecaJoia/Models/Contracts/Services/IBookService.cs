﻿using BibliotecaJoia.Models.Dtos;

namespace BibliotecaJoia.Models.Contracts.Services
{
    public interface IBookService
    {
        void Create(BookDto bookDto);
        List<BookDto> ToListBooks();
    }
}
