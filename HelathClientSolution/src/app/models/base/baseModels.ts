
export interface BaseModel<T> {
  isSuccess: boolean;
  data?: T;
  errors?: string[];
}

