import type { AuditedEntityDto } from '@abp/ng.core';

export interface StudentCreateUpdateDto {
  name?: string;
  age: number;
  gradeId: number;
}

export interface StudentDto extends AuditedEntityDto<number> {
  name?: string;
  age: number;
  gradeName: string;
}
