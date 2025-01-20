import { RestService, Rest } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';
import type { StudentCreateUpdateDto, StudentDto } from '../dto/models';

@Injectable({
  providedIn: 'root',
})
export class StudentService {
  apiName = 'Default';
  

  create = (input: StudentCreateUpdateDto, config?: Partial<Rest.Config>) =>
    this.restService.request<any, StudentDto>({
      method: 'POST',
      url: '/api/app/student',
      body: input,
    },
    { apiName: this.apiName,...config });
  

  delete = (id: number, config?: Partial<Rest.Config>) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/student/${id}`,
    },
    { apiName: this.apiName,...config });
  

  get = (id: number, config?: Partial<Rest.Config>) =>
    this.restService.request<any, StudentDto>({
      method: 'GET',
      url: `/api/app/student/${id}`,
    },
    { apiName: this.apiName,...config });
  

  getList = (input: PagedAndSortedResultRequestDto, config?: Partial<Rest.Config>) =>
    this.restService.request<any, PagedResultDto<StudentDto>>({
      method: 'GET',
      url: '/api/app/student',
      params: { sorting: input.sorting, skipCount: input.skipCount, maxResultCount: input.maxResultCount },
    },
    { apiName: this.apiName,...config });
  

  update = (id: number, input: StudentCreateUpdateDto, config?: Partial<Rest.Config>) =>
    this.restService.request<any, StudentDto>({
      method: 'PUT',
      url: `/api/app/student/${id}`,
      body: input,
    },
    { apiName: this.apiName,...config });

  constructor(private restService: RestService) {}
}
