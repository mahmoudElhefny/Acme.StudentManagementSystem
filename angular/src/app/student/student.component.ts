import { ListService, PagedResultDto } from '@abp/ng.core';
import { Component, OnInit } from '@angular/core';
import { StudentDto } from '@proxy/dto';
import { StudentService } from '@proxy/services';

@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrl: './student.component.scss',
  providers: [ListService],
})
export class StudentComponent implements OnInit {
  student = { items: [], totalCount: 0 } as PagedResultDto<StudentDto>;
  isModalOpen = false; 

  constructor(public readonly list: ListService, private bookService: StudentService) {}

  ngOnInit(): void {
    const studentStreamCreator = (query) => this.bookService.getList(query);
    this.list.hookToQuery(studentStreamCreator).subscribe((response) => {
      this.student = response;
    });
  }
  createBook() {
    this.isModalOpen = true;
  }
}
