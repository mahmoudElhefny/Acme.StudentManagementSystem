import { ListService, PagedResultDto } from '@abp/ng.core';
import { Confirmation, ConfirmationService } from '@abp/ng.theme.shared';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
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
  form: FormGroup;
  selectedStudent = {} as StudentDto; 
  studentGrades = [        //simulate Api for getting grades
    { id: 5, name: 'Grade 1' },
    { id: 6, name: 'Grade 2' },
    { id: 7, name: 'Grade 3' },
  ];           

  constructor(public readonly list: ListService, private studentService: StudentService
    ,private fb: FormBuilder ,private confirmation: ConfirmationService 

  ) {}

  ngOnInit(): void {
    const studentStreamCreator = (query) => this.studentService.getList(query);
    this.list.hookToQuery(studentStreamCreator).subscribe((response) => {
      this.student = response;
    });
  }
  createStudent() {
    this.selectedStudent = {} as StudentDto; 
    this.buildForm(); // 
    this.isModalOpen = true;
  }
  editStudent(id: number) {
    this.studentService.get(id).subscribe((student) => {
      this.selectedStudent = student;
      this.buildForm();
      this.isModalOpen = true;
    });
  }
  delete(id: number) {
    this.confirmation.warn('::AreYouSureToDelete', '::AreYouSure').subscribe((status) => {
      if (status === Confirmation.Status.confirm) {
        this.studentService.delete(id).subscribe(() => this.list.get());
      }
    });
  }
  buildForm() {
    this.form = this.fb.group({
      name: [this.selectedStudent?.name ||'', Validators.required],
      age: [this.selectedStudent?.age||null, [Validators.required,Validators.min(5), Validators.max(18)]],
      gradeId: [this.selectedStudent?.gradeId||null, Validators.required],
    });
  }
  save() {
    if (this.form.invalid) {
      return;
    }

    const request = this.selectedStudent.id
    ? this.studentService.update(this.selectedStudent.id, this.form.value)
    : this.studentService.create(this.form.value);

  request.subscribe(() => {
    this.isModalOpen = false;
    this.form.reset();
    this.list.get();
    });
  }
}
