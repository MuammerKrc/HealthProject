export class BaseModel<T>
{
  isSuccess: boolean = false;
  data: T;
  errors: string[] = [];
}

