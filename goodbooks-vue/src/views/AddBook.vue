<template>
  <div class="add-book-wrapper">
    <h1>Add Book</h1>
  </div>
</template>

<script lang="ts">
import { Component, Prop, Vue } from 'vue-property-decorator';
import IBook from '../types/Book';

@Component({
  name: "AddBook",
  components: {}
})

export default class AddBook extends Vue {
  book: IBook;
}
</script>

<style lang="scss" scoped></style>