<template>
  <div class="book-wrapper">
    <div class="book-title">
      {{ book.title }}
    </div>
    <div class="book-author">
      {{ book.author }}
    </div>
    <div class="book-created">
      {{ book.createdOn }}
    </div>
  </div>
</template>

<script lang="ts">
import { Component, Prop, Vue } from 'vue-property-decorator';
import IBook from '../types/Book';

@Component({
  name: "Book",
  components: {}
})

export default class Book extends Vue {
  @Prop({ required: true })
  book!: IBook
}
</script>

<style lang="scss" scoped>
  .book-wrapper {
    margin: 0.8rem;
    padding: 0.4rem;
    border: 1px solid #555;
    border-radius: 1rem;

    .book-author {
      color: #333;
    }

    .book-created {
      font-size: 0.9rem;
      color: #333;
    }

    .book-title {
      font-size: 1.2rem;
      font-weight: bold;
    }
  }
</style>